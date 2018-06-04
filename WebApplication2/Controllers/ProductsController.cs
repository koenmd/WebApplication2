using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        private kopjezwam_dbEntities db = new kopjezwam_dbEntities();

        // GET: Products
        public async Task<ActionResult> Index()
        {
            return View(await db.Product.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Product.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,ProductTypeId,ParentGroupedProductId,VisibleIndividually,Name,ShortDescription,FullDescription,AdminComment,ProductTemplateId,VendorId,ShowOnHomePage,MetaKeywords,MetaDescription,MetaTitle,AllowCustomerReviews,ApprovedRatingSum,NotApprovedRatingSum,ApprovedTotalReviews,NotApprovedTotalReviews,SubjectToAcl,LimitedToStores,Sku,ManufacturerPartNumber,Gtin,IsGiftCard,GiftCardTypeId,OverriddenGiftCardAmount,RequireOtherProducts,RequiredProductIds,AutomaticallyAddRequiredProducts,IsDownload,DownloadId,UnlimitedDownloads,MaxNumberOfDownloads,DownloadExpirationDays,DownloadActivationTypeId,HasSampleDownload,SampleDownloadId,HasUserAgreement,UserAgreementText,IsRecurring,RecurringCycleLength,RecurringCyclePeriodId,RecurringTotalCycles,IsRental,RentalPriceLength,RentalPricePeriodId,IsShipEnabled,IsFreeShipping,ShipSeparately,AdditionalShippingCharge,DeliveryDateId,IsTaxExempt,TaxCategoryId,IsTelecommunicationsOrBroadcastingOrElectronicServices,ManageInventoryMethodId,ProductAvailabilityRangeId,UseMultipleWarehouses,WarehouseId,StockQuantity,DisplayStockAvailability,DisplayStockQuantity,MinStockQuantity,LowStockActivityId,NotifyAdminForQuantityBelow,BackorderModeId,AllowBackInStockSubscriptions,OrderMinimumQuantity,OrderMaximumQuantity,AllowedQuantities,AllowAddingOnlyExistingAttributeCombinations,NotReturnable,DisableBuyButton,DisableWishlistButton,AvailableForPreOrder,PreOrderAvailabilityStartDateTimeUtc,CallForPrice,Price,OldPrice,ProductCost,CustomerEntersPrice,MinimumCustomerEnteredPrice,MaximumCustomerEnteredPrice,BasepriceEnabled,BasepriceAmount,BasepriceUnitId,BasepriceBaseAmount,BasepriceBaseUnitId,MarkAsNew,MarkAsNewStartDateTimeUtc,MarkAsNewEndDateTimeUtc,HasTierPrices,HasDiscountsApplied,Weight,Length,Width,Height,AvailableStartDateTimeUtc,AvailableEndDateTimeUtc,DisplayOrder,Published,Deleted,CreatedOnUtc,UpdatedOnUtc")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(product);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Product.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,ProductTypeId,ParentGroupedProductId,VisibleIndividually,Name,ShortDescription,FullDescription,AdminComment,ProductTemplateId,VendorId,ShowOnHomePage,MetaKeywords,MetaDescription,MetaTitle,AllowCustomerReviews,ApprovedRatingSum,NotApprovedRatingSum,ApprovedTotalReviews,NotApprovedTotalReviews,SubjectToAcl,LimitedToStores,Sku,ManufacturerPartNumber,Gtin,IsGiftCard,GiftCardTypeId,OverriddenGiftCardAmount,RequireOtherProducts,RequiredProductIds,AutomaticallyAddRequiredProducts,IsDownload,DownloadId,UnlimitedDownloads,MaxNumberOfDownloads,DownloadExpirationDays,DownloadActivationTypeId,HasSampleDownload,SampleDownloadId,HasUserAgreement,UserAgreementText,IsRecurring,RecurringCycleLength,RecurringCyclePeriodId,RecurringTotalCycles,IsRental,RentalPriceLength,RentalPricePeriodId,IsShipEnabled,IsFreeShipping,ShipSeparately,AdditionalShippingCharge,DeliveryDateId,IsTaxExempt,TaxCategoryId,IsTelecommunicationsOrBroadcastingOrElectronicServices,ManageInventoryMethodId,ProductAvailabilityRangeId,UseMultipleWarehouses,WarehouseId,StockQuantity,DisplayStockAvailability,DisplayStockQuantity,MinStockQuantity,LowStockActivityId,NotifyAdminForQuantityBelow,BackorderModeId,AllowBackInStockSubscriptions,OrderMinimumQuantity,OrderMaximumQuantity,AllowedQuantities,AllowAddingOnlyExistingAttributeCombinations,NotReturnable,DisableBuyButton,DisableWishlistButton,AvailableForPreOrder,PreOrderAvailabilityStartDateTimeUtc,CallForPrice,Price,OldPrice,ProductCost,CustomerEntersPrice,MinimumCustomerEnteredPrice,MaximumCustomerEnteredPrice,BasepriceEnabled,BasepriceAmount,BasepriceUnitId,BasepriceBaseAmount,BasepriceBaseUnitId,MarkAsNew,MarkAsNewStartDateTimeUtc,MarkAsNewEndDateTimeUtc,HasTierPrices,HasDiscountsApplied,Weight,Length,Width,Height,AvailableStartDateTimeUtc,AvailableEndDateTimeUtc,DisplayOrder,Published,Deleted,CreatedOnUtc,UpdatedOnUtc")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Product.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Product product = await db.Product.FindAsync(id);
            db.Product.Remove(product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
