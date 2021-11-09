using FluentValidation;
using RadiostationBLL.Interfaces;
using RadiostationBLL.ModelsDto;
using RadiostationBLL.Validators;
using RadiostationDAL;
using RadiostationDAL.Entities;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System;

namespace RadiostationBLL.Services
{
   public class RecordService: BaseService<RecordDto>, IRecordService
    {
        private readonly IRepository<Record> _recordRepository;


        public RecordService(IRepository<Record> recordRepository, IRepository<Genre> genreRepository,
            IRepository<Performer> performerRepository)
        {
            _recordRepository = recordRepository;
            Validator = new RecordValidator(recordRepository, genreRepository, performerRepository);
        }

        protected override AbstractValidator<RecordDto> Validator { get; set; }

        public ValidationResult CreateRecord(RecordDto recordDto)
        {
            var result = TryValidate(recordDto, "Create");
            if (result.IsValid)
            {
                var record = GetMapper().Map<RecordDto, Record>(recordDto);
                record.Id = _recordRepository.Create(record);
            }

            return result;
        }


        public ValidationResult UpdateRecord(RecordDto recordDto)
        {
            var result = TryValidate(recordDto, "Update");
            if (result.IsValid)
            {
                var record = GetMapper().Map<RecordDto, Record>(recordDto);
                _recordRepository.Update(record);
            }

            return result;
        }

        public ValidationResult DeleteRecord(RecordDto recordDto)
        {
            var result = TryValidate(recordDto, "Delete");
            if (result.IsValid)
            {
                var record = GetMapper().Map<RecordDto, Record>(recordDto);
                _recordRepository.Delete(record);
            }

            return result;
        }

        public RecordDto GetRecord(int recordId)
        {
            RecordDto recordDto = null;
            var record = _recordRepository.GetById(recordId);
            if (record != null)
            {
                recordDto = GetMapper().Map<Record, RecordDto>(record);
            }

            return recordDto;
        }


        public List<RecordDto> GetRecords()
        {
            var records = _recordRepository.GetAll();
            var recordsDto = GetMapper().Map<IQueryable<Record>, List<RecordDto>>(records) ?? new List<RecordDto>();

            return recordsDto;
        }

        
        public List<RecordDto> GetRecordsBy(Expression<Func<Record, bool>> predicate)
        {
            var records = _recordRepository.GetAll().Where(predicate);
            var recordsDto = GetMapper().Map<IQueryable<Record>, List<RecordDto>>(records) ?? new List<RecordDto>();

            return recordsDto;
        }
    }
}
