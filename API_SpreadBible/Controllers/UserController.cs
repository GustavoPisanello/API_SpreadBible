using API_SpreadBible.DataBase;
using API_SpreadBible.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_SpreadBible.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ChurchDBContext dbContext;

        public UserController(ChurchDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Método que recupera todos os Usuários Cadastrados
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await dbContext.Users.ToListAsync());

        }

        // Método que recupera um Usuário pelo ID
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetUser([FromRoute] Guid id)
        {
            var user = dbContext.Users.Find(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }
        // Método que adiciona novos usuários
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserRequest addUserRequest)
        {
            var newUser = new User()
            {
                UserId = Guid.NewGuid(),
                UserName = addUserRequest.UserName,
                UserEmail = addUserRequest.UserEmail,
                UserPassword = addUserRequest.UserPassword,
                FavChurch = addUserRequest.FavChurch
            };

            await dbContext.Users.AddAsync(newUser);
            await dbContext.SaveChangesAsync();

            return Ok(newUser);
        }

        // Método que atualiza usuários
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateUser([FromRoute] Guid id, UpdateUserRequest updateUserRequest)
        {
            var user = dbContext.Users.Find(id);

            if (user != null)
            {          
                user.UserName = updateUserRequest.UserName;
                user.UserEmail = updateUserRequest.UserEmail;
                user.UserPassword = updateUserRequest.UserPassword;
                user.FavChurch = updateUserRequest.FavChurch;

                await dbContext.SaveChangesAsync();

                return Ok(user);
            }
            return NotFound();
        }

        // Método que deleta usuários
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            var user = await dbContext.Users.FindAsync(id);

            if (user != null)
            {
                dbContext.Remove(user);
                await dbContext.SaveChangesAsync();
                return Ok("O usuário " + user.UserName + " foi deletado");
            }
            return NotFound();
        }
    }
}
