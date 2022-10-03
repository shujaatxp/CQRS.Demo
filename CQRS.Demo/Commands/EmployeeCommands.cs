using CQRS.Pattern.Models;
using CQRS.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Pattern.Commands
{
    public class EmployeeCommands : IEmployeeCommands
    {
        private readonly IEmployeeCommandsRepository _repository;

        public EmployeeCommands(IEmployeeCommandsRepository repository)
        {
            _repository = repository;
        }
        public void SaveEmployeeData(Employee employee)
        {
            _repository.SaveEmployee(employee);

        }
    }
}
