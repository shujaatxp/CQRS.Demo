using CQRS.Pattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Pattern.Repositories
{
    public interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);
    }
}
