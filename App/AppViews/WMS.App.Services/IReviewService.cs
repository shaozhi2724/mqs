using System;
using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IReviewService
    {
        Review GetByStoreId(int storeID, string userRealName);
        Review GetByReviewId(int reviewId);
        List<ReviewDetailViewModel> GetReviewDetails(int reviewId, int reviewAmount, StoreBillOutDetailViewModel storeBillDetail, string reviewResult);
        List<ReviewDetailViewModel> GetReviewDetails(int reviewId);
        void CancelReview(int reviewId);
        bool CompleteReview(int reviewId, bool allowNoCodeReview = false);
        bool CompleteReviewAndBill(int reviewId, bool allowNoCodeReview = false);
        bool IsReviewing(int storeID);
        bool CanReview();
        List<ReviewHistoryViewModel> SearchReviews(string reviewCode, string dealerName, int storeTypeId, DateTime startDate, DateTime endDate, string productName);
    }
}