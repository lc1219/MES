using Microsoft.AspNetCore.Mvc.Filters;

namespace MES.API.Filter
{
    public class ExceptionFilter : IExceptionFilter
    {
        //异常过滤器
        public void OnException(ExceptionContext context)
        {
            if (context.ExceptionHandled==false)
            {
                NLog.Logger logger= NLog.LogManager.GetCurrentClassLogger();
                logger.Error(context.Exception.Message);
            }
            context.ExceptionHandled = true;
        }
    }
}
