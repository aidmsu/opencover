﻿namespace OpenCover.Framework.Filtering
{
    /// <summary>
    /// The type of filter, an exclusion filter takes precedence over inclusion filter
    /// </summary>
    public enum FilterType
    {
        /// <summary>
        /// The filter is an inclusion type, i.e. if a assembly/class pair 
        /// matches the filter then it is included for instrumentation
        /// </summary>
        Inclusion,

        /// <summary>
        /// The filter is an exclusion type, i.e. if a assembly/class pair 
        /// matches the filter then it is excluded for instrumentation
        /// </summary>
        Exclusion
    }
}