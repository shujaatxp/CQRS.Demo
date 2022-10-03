using CQRS.Pattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Pattern.Commands
{
    public interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);
    }
}
