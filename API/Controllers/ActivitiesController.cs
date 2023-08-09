using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Activities.Queries.GetActivities;
using Application.Features.Activities.Queries.GetActivity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ActivitiesController:BaseApiController
    {
        private readonly IMediator meditor;

        public ActivitiesController(IMediator meditor)
        {
            this.meditor = meditor;
        }

        [HttpGet]
        public async Task<IActionResult> Get(){
            var result= await meditor.Send(new GetActivitiesQuery());
            return  Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityDto>> Get(string id)
        {
            var data = await meditor.Send(new GetActivityQuery(id));
            return data;
        }

    }
}