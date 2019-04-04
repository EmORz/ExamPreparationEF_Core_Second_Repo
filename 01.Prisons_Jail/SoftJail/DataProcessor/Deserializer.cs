using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using SoftJail.Data.Models;

namespace SoftJail.DataProcessor
{

    using Data;
    using System;

    public class Deserializer
    {
        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            //var sb = new StringBuilder();
            //var deserializeDepartments = JsonConvert.DeserializeObject<DepartmentDto[]>(jsonString);
            //var validDepartment = new List<Department>();

            //foreach (var departmentDto in deserializeDepartments)
            //{
            //    if (!IsValid(departmentDto) || !departmentDto.Cells.All(IsValid))
            //    {
            //        sb.AppendLine("Invalid Data");
            //        continue;
            //    }

            //    var cells = departmentDto.Cells.Select(x => new Cell(x.CellNumber, x.HasWindow)).ToArray();
            //    var department = new Department
            //    {
            //        Name = departmentDto.Name,
            //        Cells = cells
            //    };

            //    validDepartment.Add(department);
            //    sb.AppendLine($"Imported {department.Name} with {cells.Length} cells");
            //}
            //context.Departments.AddRange(validDepartment);
            //context.SaveChanges();

            //return sb.ToString().TrimEnd();
            throw new NotImplementedException();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            //var sb = new StringBuilder();
            //var deserializePrisonersMailsDtos = JsonConvert.DeserializeObject<ImportPrisonersMailsDto[]>(jsonString);
            //var validPrisoners= new List<Prisoner>();

            //foreach (var departmentDto in deserializePrisonersMailsDtos)
            //{
            //    if (!IsValid(departmentDto) || !departmentDto.Mails.All(IsValid))
            //    {
            //        sb.AppendLine("Invalid Data");
            //        continue;
            //    }

            //    var mails = departmentDto.Mails.Select(x => new Mail(x.Description, x.Address, x.Sender)).ToArray();

            //    var prisoner = new Prisoner
            //    {
            //        FullName = departmentDto.FullName,
            //        Nickname = departmentDto.Nickname,
            //        Age = departmentDto.Age,
            //        IncarcerationDate =  DateTime.ParseExact(departmentDto.IncarcerationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
            //        ReleaseDate = DateTime.ParseExact(departmentDto.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
            //        //Bail = departmentDto.Bail,
            //        //CellId = departmentDto.CellId,
            //        Mails = mails

            //    };


            

            //    validPrisoners.Add(prisoner);
            //    sb.AppendLine($"Imported {prisoner.FullName} {prisoner.Age} years old");
            //}
            //context.Prisoners.AddRange(validPrisoners);
            //context.SaveChanges();

          //  return sb.ToString().TrimEnd();
            throw new NotImplementedException();
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            throw new NotImplementedException();
        }
        public static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var result = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, result, true);
        }
    }
}