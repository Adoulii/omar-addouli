
﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;


namespace TaskSystem.CoreApplication.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController:Controller{

        private readonly IGenericRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public TaskController(IUnitOfWork unitOfWork)
        {
            this._repository = unitOfWork.Repository<TEntity>();
            this._unitOfWork = unitOfWork;
        }


        [HttpGet]
        [Route("")]
        public async Task<IActionResult> getAllTasks(){
            return  GetAll();
        }

        
        [HttpGet]
        [Route("add")]
        public async Task<IActionResult> addNewTask(Task c){
            return Add(c);

        }

    }

}
