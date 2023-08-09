using Application.Features.Activities.Queries.GetActivities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Activities.Queries.GetActivity
{
    public class GetActivityQuery:IRequest<ActivityDto>
    {
        public GetActivityQuery(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
