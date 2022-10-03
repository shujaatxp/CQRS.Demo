using CQRS.Pattern.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Pattern.Queries
{
    public interface IEmployeeQueries
    {
        EmployeeDTO FindByID(int employeeID);

    }
}
