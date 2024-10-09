namespace LabAspNetApp.Services
{
    public class TimeService
    {
        public string GetTimeOfDay()
        {
            var now = DateTime.Now.TimeOfDay;

            if (now.Hours >= 6 && now.Hours < 12)
                return "зараз ранок";
            if (now.Hours >= 12 && now.Hours < 18)
                return "зараз день";
            if (now.Hours >= 18 && now.Hours < 24)
                return "зараз вечір";

            return "зараз ніч";
        }
    }
}
