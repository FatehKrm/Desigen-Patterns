namespace DesigenPattern.TemplateMethod.TemplatePattern
{
    public abstract class NetflixPlans
    {
        public void CreatePlan()
        {
            PlanType(string.Empty);
            CountPerson(0);
            Price(0);
            Resoulution(string.Empty);
            Content(string.Empty);
        }
        public abstract string PlanType(string planType);
        public abstract int CountPerson(int count);
        public abstract decimal Price(decimal price);
        public abstract string Resoulution(string resulution);
        public abstract string Content(string content);
        
    }
}
