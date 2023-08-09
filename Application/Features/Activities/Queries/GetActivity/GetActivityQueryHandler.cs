using Application.Contracts.Persistence;
using Application.Features.Activities.Queries.GetActivities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Activities.Queries.GetActivity
{
    internal class GetActivityQueryHandler : IRequestHandler<GetActivityQuery, ActivityDto>
    {
        private readonly IActivityRepository _activityRepository;
        private readonly IMapper mapper;

        public GetActivityQueryHandler(IActivityRepository activityRepository, IMapper mapper)
        {
            _activityRepository = activityRepository;
            this.mapper = mapper;
        }

        public async Task<ActivityDto> Handle(GetActivityQuery request, CancellationToken cancellationToken)
        {
            var data =await _activityRepository.GetByIdAsync(Guid.Parse( request.Id));
            return mapper.Map<ActivityDto>(data);
        }
    }
}
