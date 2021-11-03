using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CentricConsultingProjectTeam1.Models;

namespace CentricConsultingProjectTeam1.DAL
{
    public class CentricConsultingProjectTeam1Context : DbContext 
    {
        public CentricConsultingProjectTeam1Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Recognize> Recognizes { get; set; }

    }
    

}