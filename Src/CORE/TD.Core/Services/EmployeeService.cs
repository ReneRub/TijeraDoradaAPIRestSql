using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Net;
using TD.Common;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;
using TD.Core.Abstraction.Services;
using TD.Infrastructure.Abstraction.Entities;
using TD.Infrastructure.Abstraction.Repositories;
using TD.Infrastructure.Abstraction.UnitOfWork;

namespace TD.Core.Services
{
    /// <summary>
    /// Class EmployeeService
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        private readonly ILogger<EmployeeService> logger;
        private readonly IMapper mapper;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository, ILogger<EmployeeService> logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.employeeRepository = employeeRepository;
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Get all employees
        /// </summary>
        public async Task<StandardResponse<List<EmployeeStylistResponseDto>>> GetStylist(int sucursal)
        {
            var employees = await employeeRepository
                .GetStylist(sucursal)
                .ConfigureAwait(false);

            var employeesDto = employees.Any() ?  this.mapper.Map<List<CatEmpleado>, List<EmployeeStylistResponseDto>>(employees.ToList()) : null;

            return employeesDto == null ? new StandardResponse<List<EmployeeStylistResponseDto>>(HttpStatusCode.NotFound, message: ResourcesManager.GetResourceValue("NotFound")) 
                : new StandardResponse<List<EmployeeStylistResponseDto>>(HttpStatusCode.OK, employeesDto, ResourcesManager.GetResourceValue("GetSuccess"));
        }

        /// <summary>
        /// Get all employees
        /// </summary>
        public async Task<StandardResponse<List<EmployeeResponseDto>>> GetAllEmployees()
        {
            var employees = await employeeRepository
                .GetEmployees()
                .ConfigureAwait(false);

            var employeesDto = employees.Any() ? this.mapper.Map<IEnumerable<CatEmpleado>, List<EmployeeResponseDto>>(employees.ToList()) : null;

            return employeesDto == null ? new StandardResponse<List<EmployeeResponseDto>>(HttpStatusCode.NotFound, message: ResourcesManager.GetResourceValue("NotFound")) :
                new StandardResponse<List<EmployeeResponseDto>>(HttpStatusCode.OK, employeesDto, ResourcesManager.GetResourceValue("GetSuccess"));
        }

        /// <summary>
        /// Update employee
        /// </summary>
        public async Task<StandardResponse<bool>> UpdateEmployee(int id, EmployeeRequestDto employee)
        {
            var employeeUpd = await employeeRepository.GetOne(x => x.CveEmpleado == id).ConfigureAwait(false);

            if (employeeUpd == null)
            {
                return new StandardResponse<bool>(HttpStatusCode.NotFound, false, message: ResourcesManager.GetResourceValue("UpdateEmployeeError"));
            }
            employeeUpd.Curp = employee.Curp;
            employeeUpd.CveSucursal = employee.CveSucursal;
            employeeUpd.SeguroSocial = employee.SeguroSocial;
            employeeUpd.FechaNac = employee.FechaNac;
            employeeUpd.Alias = employee.Alias;
            employeeUpd.Email = employee.Email;
            employeeUpd.CveTurno = employee.CveTurno;
            employeeUpd.CtaBancaria = employee.CtaBancaria;
            employeeUpd.Disponibilidad = employee.Disponibilidad;
            employeeUpd.CveStatusEmpleado = employee.CveStatusEmpleado;
            employeeUpd.CveTipoEmpleado= employee.CveTipoEmpleado;
            employeeUpd.Nombre = employee.Nombre;
            employeeUpd.Usuario= employee.Usuario;
            employeeUpd.Password = employee.Password;
            employeeUpd.Telefono= employee.Telefono;
            employeeUpd.Telefono2 = employee.Telefono2;
            employeeUpd.Rfc = employee.Rfc;
            employeeUpd.FechaIngreso = employee.FechaIngreso;
            employeeUpd.Direccion = employee.Direccion;
            employeeUpd.DiaDescanso= employee.DiaDescanso;
            employeeUpd.Disponibilidad= employee.Disponibilidad;

            employeeRepository.Update(employeeUpd);
            
            var response = await unitOfWork.SaveAsync().ConfigureAwait(false);

            return response == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("UpdateEmployeeError"))
                   : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("UpdateEmployee"), employeeUpd.Nombre));
        }

        /// <summary>
        /// Get Employee By Id
        /// </summary>
        public async Task<StandardResponse<CatEmpleado>> GetEmployeeById(int id)
        {
            var employee = await employeeRepository
                .GetEmployee(id)
                .ConfigureAwait(false);

            return employee == null ? new StandardResponse<CatEmpleado>(HttpStatusCode.NotFound, message: ResourcesManager.GetResourceValue("NotFound")) 
                : new StandardResponse<CatEmpleado>(HttpStatusCode.OK, employee, ResourcesManager.GetResourceValue("GetSuccess"));
   
        }

        /// <summary>
        /// Create Employee
        /// </summary>
        public async Task<StandardResponse<bool>> CreateEmployee(EmployeeRequestDto employee)
        {
            var pass = employee.Password;
            var user = employee.Usuario;

            var employeeexist = await employeeRepository.GetOne(x => x.Usuario == user && x.Password == pass).ConfigureAwait(false);
            
            if (employeeexist == null)
            {
                var employees2 = await employeeRepository.GetAll();
                var lastEmployeeId = employees2.OrderByDescending(x => x.CveEmpleado).First();
                var newEmployee = mapper.Map<CatEmpleado>(employee);
                newEmployee.CveEmpleado = lastEmployeeId.CveEmpleado + 1;
                await employeeRepository.Add(newEmployee).ConfigureAwait(false);
                var dbResponse = await unitOfWork.SaveAsync().ConfigureAwait(false);

                return dbResponse == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("AddEmployeeError")) 
                    : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("AddSuccessUser"), user));
            }
            return new StandardResponse<bool>(HttpStatusCode.BadRequest, false, ResourcesManager.GetResourceValue("AddEmployeeError"));

        }
    }
}
