using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.Activities.Queries.GetActivities
{
    public class GetActivitiesQueryHandler : IRequestHandler<GetActivitiesQuery, List<ActivityDto>>
    {
        private readonly IActivityRepository repository;
        private readonly IMapper mapper;

        public GetActivitiesQueryHandler(IActivityRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<ActivityDto>> Handle(GetActivitiesQuery request, CancellationToken cancellationToken)
        {

            var result=await repository.GetAllAsync();
            return mapper.Map<List<ActivityDto>>(result);
        }
    }
}