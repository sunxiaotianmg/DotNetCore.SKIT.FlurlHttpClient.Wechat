using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteSmartGuideExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /smartguide/guides 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/after-payment-service/guides/insert-guide.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/after-payment-service/guides/insert-guide.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateSmartGuideResponse> ExecuteCreateSmartGuideAsync(this WechatTenpayClient client, Models.CreateSmartGuideRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "smartguide", "guides");

            return await client.SendRequestWithJsonAsync<Models.CreateSmartGuideResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /smartguide/guides/{guide_id}/assign 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/after-payment-service/guides/assign-guide.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/after-payment-service/guides/assign-guide.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AssignSmartGuideResponse> ExecuteAssignSmartGuideAsync(this WechatTenpayClient client, Models.AssignSmartGuideRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "smartguide", "guides", request.GuideId, "assign");

            return await client.SendRequestWithJsonAsync<Models.AssignSmartGuideResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /smartguide/guides 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/after-payment-service/guides/list-guides.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/after-payment-service/guides/list-guides.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QuerySmartGuidesResponse> ExecuteQuerySmartGuidesAsync(this WechatTenpayClient client, Models.QuerySmartGuidesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "smartguide", "guides")
                .SetQueryParam("store_id", request.StoreId.ToString());

            if (request.SubMerchantId != null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.UserId != null)
                flurlReq.SetQueryParam("userid", request.UserId);

            if (request.UserMobile != null)
                flurlReq.SetQueryParam("mobile", request.UserMobile);

            if (request.UserWorkId != null)
                flurlReq.SetQueryParam("work_id", request.UserWorkId);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset != null)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestWithJsonAsync<Models.QuerySmartGuidesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /smartguide/guides/{guide_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/after-payment-service/guides/update-guide.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/after-payment-service/guides/update-guide.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateSmartGuideResponse> ExecuteUpdateSmartGuideAsync(this WechatTenpayClient client, Models.UpdateSmartGuideRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, new HttpMethod("PATCH"), "smartguide", "guides", request.GuideId);

            return await client.SendRequestWithJsonAsync<Models.UpdateSmartGuideResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
