﻿using Atata;
using NUnit.Framework;

namespace AtataSampleApp.UITests
{
    public class PlanTests : UITestFixture
    {
        private const string Feature1 = "Feature 1";
        private const string Feature2 = "Feature 2";
        private const string Feature3 = "Feature 3";
        private const string Feature4 = "Feature 4";
        private const string Feature5 = "Feature 5";
        private const string Feature6 = "Feature 6";

        [Test]
        public void Plans()
        {
            Go.To<PlansPage>().
                PlanItems.Count.Should.Equal(3).

                PlanItems[0].Title.Should.Equal("Basic").
                PlanItems[0].Price.Should.Equal(0).
                PlanItems[0].NumberOfProjects.Should.Equal(1).
                PlanItems[0].Features.Should.EqualSequence(Feature1, Feature2).

                PlanItems[1].Title.Should.Equal("Plus").
                PlanItems[1].Price.Should.Equal(19.99m).
                PlanItems[1].NumberOfProjects.Should.Equal(3).
                PlanItems[1].Features.Should.EqualSequence(Feature1, Feature2, Feature3, Feature4).

                PlanItems[2].Title.Should.Equal("Premium").
                PlanItems[2].Price.Should.Equal(49.99m).
                PlanItems[2].NumberOfProjects.Should.Equal(10).
                PlanItems[2].Features.Should.EqualSequence(Feature1, Feature2, Feature3, Feature4, Feature5, Feature6);
        }
    }
}
