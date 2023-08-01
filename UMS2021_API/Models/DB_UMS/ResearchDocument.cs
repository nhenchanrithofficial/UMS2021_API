using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UMS2021_API.Models.DB_UMS
{
    public partial class ResearchDocument
    {
        public int Rdid { get; set; }
        public int? StatusId { get; set; }
        public int? ChoiceId { get; set; }
        public string Topic { get; set; }
        public string TopicKh { get; set; }
        public string Advisors { get; set; }
    }
}
