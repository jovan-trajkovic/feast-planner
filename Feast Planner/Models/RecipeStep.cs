namespace Feast_Planner.Models
{
    public class RecipeStep
    {
        public string Id { get; set; }
        public string RecipeId { get; set; }
        public int StepNumber { get; set; }
        public string StepDescription { get; set; }
        public RecipeStep()
        {
            
        }
    }
}
