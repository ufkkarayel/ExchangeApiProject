
namespace ExchangeApiProject.Models
{
    public class ExchangeViewModel
    {

        public class Rootobject
        {
            public string start_date { get; set; }
            public string _base { get; set; }
            public bool success { get; set; }
            public string end_date { get; set; }
            public bool timeseries { get; set; }
            public Rates rates { get; set; }
        }

        public class Rates
        {
            public _20231217 _20231217 { get; set; }
            public _20231206 _20231206 { get; set; }
            public _20231207 _20231207 { get; set; }
            public _20231219 _20231219 { get; set; }
            public _20231218 _20231218 { get; set; }
          
        }

        public class _20231217
        {
            public float TRY { get; set; }
            public float USD { get; set; }
        }

        public class _20231206
        {
            public float TRY { get; set; }
            public float USD { get; set; }
        }

        public class _20231207
        {
            public float TRY { get; set; }
            public float USD { get; set; }
        }

        public class _20231219
        {
            public float TRY { get; set; }
            public float USD { get; set; }

        }

        public class _20231218
        {
            public float TRY { get; set; }
            public float USD { get; set; }

        }

        
        

    }
}
