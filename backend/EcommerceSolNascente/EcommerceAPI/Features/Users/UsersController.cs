using EcommerceAPI.Features.Users.Services.Create;
using EcommerceAPI.Features.Users.Services.Delete;
using EcommerceAPI.Features.Users.Services.Edit;
using EcommerceAPI.Features.Users.Services.Get;
using EcommerceAPI.Features.Users.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Features.Users;

[Route("[controller]")]
[ApiController]
public class UsersController(IGetUser getUserService,
                             IEditUser editUserService,
                             IInactiveUser inactiveUserService,
                             ICreateUser createUserService) : Controller
{
    private readonly IGetUser GetUserService = getUserService;
    private readonly ICreateUser CreateUserService = createUserService;
    private readonly IEditUser EditUserService = editUserService;
    private readonly IInactiveUser InactiveUserService = inactiveUserService;

    [HttpGet]
    [ProducesResponseType<IList<UserVm>>(200)]
    public async Task<IList<UserVm>> List() 
        => await GetUserService.ListAsync();

    [HttpGet("{id}")]
    [ProducesResponseType<UserVm>(200)]
    public async Task<UserVm?> Find(long id)
        => await GetUserService.FindAsync(id);

    [HttpPost]
    [ProducesResponseType<UserVm>(200)]
    public async Task<UserVm?> Create([FromBody] CreateUserVm vm)
        => await CreateUserService.CreateAsync(vm);

    [HttpPut("{id}")]
    [ProducesResponseType<UserVm>(200)]
    public async Task<UserVm?> Update(long id, [FromBody] CreateUserVm vm)
        => await EditUserService.EditAsync(id, vm);

    [HttpDelete("{id}")]
    [ProducesResponseType<UserVm>(200)]
    public async Task<bool> Inactivate(long id)
        => await InactiveUserService.Inactivate(id);
}
