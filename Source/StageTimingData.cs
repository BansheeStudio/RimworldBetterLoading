﻿using System;
using System.Collections.Generic;
using BetterLoading.Stage;

namespace BetterLoading
{
    public class StageTimingData
    {
        internal static readonly List<StageTimingData> ExecutedStages = new List<StageTimingData>();
        
        public DateTime start;
        public DateTime end;
        public LoadingStage stage;
    }
}