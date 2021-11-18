using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RadiostationWeb.Data;
using RadiostationWeb.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RadiostationWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly BDLab1Context _dbContext;
        public AccountController(UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager, BDLab1Context dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
        }

        public ActionResult Login(string returnUrl = "/")
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect(returnUrl);
            }
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl,
            });
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginModel.Username);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    var sigInResult = await _signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);
                    if (sigInResult.Succeeded)
                    {
                        return Redirect(loginModel?.ReturnUrl ?? "/");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View(loginModel);
        }




        [Authorize]
        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await _signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult ManageUsers(string nameFilter, string surnameFilter, int page = 1)
        {
            var pageSize = 20;
            var users = FilterUsers(nameFilter, surnameFilter);
            var pageUsers = users.OrderBy(o => o.Id).Skip((page - 1) * pageSize).Take(pageSize);
            PageViewModel pageViewModel = new PageViewModel(users.Count(), page, pageSize);
            var viewUsers = pageUsers.ToList();
            var pageItemsModel = new PageItemsModel<ApplicationUser> { Items = viewUsers, PageModel = pageViewModel };
            return View(pageItemsModel);
        }

        private IQueryable<ApplicationUser> FilterUsers(string nameFilter, string surnameFilter)
        {
            IQueryable<ApplicationUser> users = _userManager.Users;
            nameFilter = nameFilter ?? HttpContext.Request.Cookies["nameFilter"];
            if (!string.IsNullOrEmpty(nameFilter))
            {
                users = users.Where(e => e.Name.Contains(nameFilter));
                HttpContext.Response.Cookies.Append("nameFilter", nameFilter);
            }

            surnameFilter = surnameFilter ?? HttpContext.Request.Cookies["surnameFilter"];
            if (!string.IsNullOrEmpty(surnameFilter))
            {
                users = users.Where(e => e.Surname.Contains(surnameFilter));
                HttpContext.Response.Cookies.Append("surnameFilter", surnameFilter);
            }

            if (nameFilter == " " && surnameFilter == " ")
            {
                users = _userManager.Users;
            }
            return users;
        }

        public IActionResult ResetManageFilter()
        {
            HttpContext.Response.Cookies.Delete("nameFilter");
            HttpContext.Response.Cookies.Delete("surnameFilter");
            return RedirectToAction(nameof(ManageUsers));
        }

        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> AddRole(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null && roleName != null)
            {
                await _userManager.AddToRoleAsync(user, roleName);
                if (roleName.Equals("Employee"))
                {
                    _dbContext.Employees.Add(new Employee { AspNetUserId = userId });
                    _dbContext.SaveChanges();
                }
            }
            return RedirectToAction("ManageUsers");
        }

        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteRole(string userId, string roleName)
        {
            var currentUserId = _userManager.GetUserId(User);
            if (currentUserId != userId || roleName != "Admin")
            {
                var user = await _userManager.FindByIdAsync(userId);
                var employee = _dbContext.Employees.FirstOrDefault(o => o.AspNetUserId.Equals(userId));
                if (user != null && roleName != null)
                {
                    await _userManager.RemoveFromRoleAsync(user, roleName);
                    if (roleName.Equals("Employee"))
                    {
                        _dbContext.Employees.Remove(employee);
                        _dbContext.SaveChanges();
                    }
                }
            }
            return RedirectToAction("ManageUsers");
        }

        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(string userId)
        {
            var currentUserId = _userManager.GetUserId(User);
            if (userId != null && userId != currentUserId)
            {
                var user = await _userManager.FindByIdAsync(userId);
                await _userManager.DeleteAsync(user);
            }

            return RedirectToAction("ManageUsers");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View(new RegistrationViewModel());
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult> Create(RegistrationViewModel registrationModel, string userRole = "User")
        {
            if (await _userManager.FindByNameAsync(registrationModel.Username) != null)
            {
                ModelState.AddModelError("", "Username already exists");
            }

            if (await _userManager.FindByEmailAsync(registrationModel.Email) != null)
            {
                ModelState.AddModelError("", "Email already exists");
            }

            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = registrationModel.Username,
                    Email = registrationModel.Email,
                    Name=registrationModel.Name,
                    Surname=registrationModel.Surname,
                    MiddleName=registrationModel.MiddleName
                };
                var creatingReuslt = await _userManager.CreateAsync(user, registrationModel.Password);

                if (creatingReuslt.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, userRole);
                    if (userRole.Equals("Employee"))
                    {
                        _dbContext.Employees.Add(new Employee { AspNetUserId = user.Id });
                        _dbContext.SaveChanges();
                    }
                    return RedirectToAction("ManageUsers");
                }
            }

            return View(registrationModel);
        }

        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Edit(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult> Edit(ApplicationUser user)
        {
            var userByUsername = await _userManager.FindByNameAsync(user.UserName);
            if (userByUsername != null && userByUsername.Id != user.Id)
            {
                ModelState.AddModelError("", "Username already exists");
            }

            var userByEmail = await _userManager.FindByEmailAsync(user.Email);
            if (userByEmail != null && userByEmail.Id != user.Id)
            {
                ModelState.AddModelError("", "Email already exists");
            }

            if (ModelState.IsValid)
            {
                ApplicationUser foundUser = await _userManager.FindByIdAsync(user.Id);
                foundUser.UserName = user.UserName;
                foundUser.Email = user.Email;
                foundUser.Name = user.Name;
                foundUser.Surname = user.Surname;
                foundUser.MiddleName = user.MiddleName;

                await _userManager.UpdateAsync(foundUser);
                ViewData["SuccessMessage"] = "Successfully edited";
            }

            return RedirectToAction("ManageUsers");
        }

        public ActionResult Registration(string returnUrl="/")
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect(returnUrl);
            }
            return View(new RegistrationViewModel());
        }

        [HttpPost]
        public async Task<ActionResult> Registration(RegistrationViewModel registrationModel)
        {
            if (await _userManager.FindByNameAsync(registrationModel.Username) != null)
            {
                ModelState.AddModelError("", "Username already exists");
            }

            if (await _userManager.FindByEmailAsync(registrationModel.Email) != null)
            {
                ModelState.AddModelError("", "Email already exists");
            }

            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = registrationModel.Username,
                    Email = registrationModel.Email,
                    Name=registrationModel.Name,
                    Surname=registrationModel.Surname,
                    MiddleName=registrationModel.MiddleName
                };
                var creatingReuslt = await _userManager.CreateAsync(user, registrationModel.Password);
                if (creatingReuslt.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                    await _signInManager.PasswordSignInAsync(user, registrationModel.Password, false, false);
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(registrationModel);
        }
    }
}
