﻿using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using VisaNet.Common.Resource.Presentation;
using VisaNet.Common.Security.Entities.Enums;
using VisaNet.Common.Security.Filters.Web;
using VisaNet.Domain.EntitiesDtos.Enums;
using VisaNet.Presentation.Administration.Mappers;
using VisaNet.Presentation.Administration.Models;
using VisaNet.Presentation.Core;
using VisaNet.Presentation.Core.WebApi.Interfaces.Interfaces.Administration;
using VisaNet.Utilities.Notifications;

namespace VisaNet.Presentation.Administration.Controllers
{
    public class HelpController : BaseController
    {
        private readonly IPageClientService _pageClientService;

        public HelpController(IPageClientService pageClientService)
        {
            _pageClientService = pageClientService;
        }

        [CustomAuthentication(Actions.HelpDetails)]
        public async Task<ActionResult> Details()
        {
            var page = await _pageClientService.FindType(PageTypeDto.Help);

            if (page.Content != null) page.Content = page.Content.Replace(Environment.NewLine, string.Empty);

            return View(page.ToModel());
        }

        [CustomAuthentication(Actions.HelpEdit)]
        public async Task<ActionResult> Edit(Guid id)
        {
            try
            {
                var page = await _pageClientService.Find(id);

                if (page.Content != null) page.Content = page.Content.Replace(Environment.NewLine, string.Empty);

                return View(page.ToModel());
            }
            catch (WebApiClientBusinessException e)
            {
                ShowNotification(e.Message, NotificationType.Error);
            }
            catch (WebApiClientFatalException e)
            {
                ShowNotification(e.Message, NotificationType.Error);
            }
            return RedirectToAction("Details");
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        [CustomAuthentication(Actions.HelpEdit)]
        public async Task<ActionResult> Edit(PageModel page)
        {
            try
            {
                page.Content = page.Content.Replace("\"", "'");
                await _pageClientService.Edit(page.ToDto());
                ShowNotification(PresentationCoreMessages.NotificationSuccess, NotificationType.Success);
                return RedirectToAction("Details");
            }
            catch (WebApiClientBusinessException e)
            {
                ShowNotification(e.Message, NotificationType.Error);
            }
            catch (WebApiClientFatalException e)
            {
                ShowNotification(e.Message, NotificationType.Error);
            }

            if (page.Content != null) page.Content = page.Content.Replace(Environment.NewLine, string.Empty);
            return View(page);
        }
    }
}