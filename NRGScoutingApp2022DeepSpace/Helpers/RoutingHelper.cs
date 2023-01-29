namespace NRGScoutingApp2022DeepSpace.Helpers
{
    internal static class RoutingHelper
    {
        public static void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(Views.MatchEntryViews.MatchTimerPage), typeof(Views.MatchEntryViews.MatchTimerPage));
            Routing.RegisterRoute(nameof(Views.MatchEntryViews.MatchEventsPage), typeof(Views.MatchEntryViews.MatchEventsPage));
            Routing.RegisterRoute(nameof(Views.MatchEntryViews.MatchInfoPage), typeof(Views.MatchEntryViews.MatchInfoPage));
        }
    }
}
