namespace DesigenPattern.TemplateMethod.TemplatePattern
{
    public class BasicPlan : NetflixPlans
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int CountPerson(int count)
        {
            return count;
        }

        public override string PlanType(string planType)
        {
            return planType;
        }

        public override decimal Price(decimal price)
        {
            return price;
        }

        public override string Resoulution(string resulution)
        {
            return resulution;
        }
    }
}
