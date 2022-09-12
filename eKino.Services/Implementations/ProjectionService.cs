﻿using AutoMapper;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;
using eKino.Services.Database;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using eKino.Model;
using eKino.Services.Helpers;
using eKino.Services.Interfaces;

namespace eKino.Services.Implementations
{
    public class ProjectionService : BaseCRUDService<Model.Projection, Database.Projection, ProjectionSearchObject, ProjectionUpsertRequest, ProjectionUpsertRequest>, IProjectionService
    {
        public ProjectionService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Projection> AddFilter(IQueryable<Database.Projection> query, ProjectionSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search?.DateOfProjection != null)
            {
                filteredQuery = filteredQuery.Where(x => x.DateOfProjection.Date == search.DateOfProjection.Value.Date);
            }
            
            if (search?.AuditoriumId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.AuditoriumId == search.AuditoriumId);
            }
            
            if (search?.MovieId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.MovieId == search.MovieId);
            }
            filteredQuery = filteredQuery.Where(x => !x.IsDeleted);

            return filteredQuery;
        }

        public override IQueryable<Database.Projection> AddInclude(IQueryable<Database.Projection> query, ProjectionSearchObject search = null)
        {
            query = query.Include(x => x.Auditorium);
            query = query.Include(x => x.Movie);
            return base.AddInclude(query, search);
        }

    }
}