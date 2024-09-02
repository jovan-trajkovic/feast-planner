namespace Feast_Planner.Models
{
    public class Recipe
    {
        public string Id { get; set; }
        public string RecipeName { get; set; }
        public string PostedBy { get; set; }//user's id
        public int Portions { get; set; }
        public DateOnly DatePosted { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public string Description { get; set; }
        public string CuisineType { get; set; }//id of the cuisine type (1:n)
        public string Difficulty { get; set; }//id of the difficulty
        public string MealType { get; set; }//id of the meal type
        //need more props, images (n:m table?), text, additional notes, ingredients (n:m table?)
        public Recipe()
        {
        }
    }
}
