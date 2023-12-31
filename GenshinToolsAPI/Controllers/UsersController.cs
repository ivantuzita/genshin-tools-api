﻿using GenshinToolsAPI.Data;
using GenshinToolsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenshinToolsAPI.Controllers {
    [Route("api/user")]
    [ApiController]
    public class UsersController : ControllerBase {

        private readonly GenshinContext _dbContext;

        public UsersController(GenshinContext dbContext) {
            _dbContext = dbContext;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User userObj) {

            if (userObj == null) {
                //returns 400
                return BadRequest();
            }
            var user = await _dbContext.Users.FirstOrDefaultAsync(user => user.Username == userObj.Username &&
                user.Password == userObj.Password);
            if (user == null) {
                //returns 404
                return NotFound(new { Message = "User not found!" });
            }
            //returs 200
            return Ok(new {
                Status = 200,
                Message = "Login Success!",
                UserId = user.Id,
                Username = user.Username
            });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User userObj) {
            if (userObj == null) {
                //returns 400
                return BadRequest();
            }

            await _dbContext.Users.AddAsync(userObj);
            await _dbContext.SaveChangesAsync();
            return Ok(new {
                Status = 200,
                Message = "User Added!"
            });

        }

    }
}
