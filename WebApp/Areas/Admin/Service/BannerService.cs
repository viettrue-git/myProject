using Microsoft.Extensions.Options;
using PagedList;
using WebApp.Models;

namespace WebApp.Areas.Admin.Service
{
    public class BannerService
    {

        private WebContext _webContext;
        public BannerService(IOptions<AppSettings> settings)
        {
           _webContext = new WebContext(settings);
        }
        
        /// <summary>
        /// get all banner paging
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public IEnumerable<Banner> GetAllBanner(int pageIndex = 1,int pageSize = 10)
        {
            var list = _webContext.banners.OrderBy(x => x.BannerId).ToList().ToPagedList(pageIndex, pageSize);
            return list;
        }

    }
}
