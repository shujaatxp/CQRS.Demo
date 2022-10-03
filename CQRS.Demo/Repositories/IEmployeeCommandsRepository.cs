using CQRS.Pattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Pattern.Repositories
{
    public interface IEmployeeCommandsRepository
    {
       void SaveEmployee(Employee employee);

    }
}
