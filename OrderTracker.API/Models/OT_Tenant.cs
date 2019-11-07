using System;

namespace OrderTracker.API.Models
{
    public class OT_Tenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }

        public string Token { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}