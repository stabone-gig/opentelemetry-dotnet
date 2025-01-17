﻿// <copyright file="LabelSet.cs" company="OpenTelemetry Authors">
// Copyright 2018, OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
using System.Collections.Generic;

namespace OpenTelemetry.Metrics
{
    /// <summary>
    /// Normalized name value pairs of metric labels.
    /// </summary>
    public class LabelSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelSet"/> class.
        /// </summary>
        /// <param name="labels">labels from which labelset should be constructed.</param>
        public LabelSet(IEnumerable<KeyValuePair<string, string>> labels)
        {
            this.Labels = labels;
        }

        /// <summary>
        /// Gets or sets the labels for this LabelSet.
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> Labels { get; set; }
    }
}
