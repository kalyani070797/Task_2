using Task_2.Model.Response;

namespace Task_2.Core.Ratingss.Interface
{
    public interface ITopSellingProductByRatingCount
    {
        List<RatingModel> ProductByRatingCount(int year);
    }
}