using RadiostationBLL.ModelsDto;
using RadiostationDAL.Entities;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq.Expressions;


namespace RadiostationBLL.Interfaces
{
    public interface IRecordService
    {

        ValidationResult CreateRecord(RecordDto recordDto);


        ValidationResult UpdateRecord(RecordDto recordDto);

        ValidationResult DeleteRecord(RecordDto recordDto);

        RecordDto GetRecord(int recordId);


        List<RecordDto> GetRecords();

        List<RecordDto> GetRecordsBy(Expression<Func<Record, bool>> predicate);
    }
}
