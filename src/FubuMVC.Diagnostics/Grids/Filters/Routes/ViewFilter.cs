﻿using FubuMVC.Core.Registration.Nodes;
using FubuMVC.Diagnostics.Grids.Columns.Routes;

namespace FubuMVC.Diagnostics.Grids.Filters.Routes
{
	public class ViewFilter : GridFilterBase<ViewColumn, BehaviorChain>
    {
    	public ViewFilter(ViewColumn column) 
			: base(column)
    	{
    	}
    }
}