﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Entities.Assessment {
	using ImsGlobal.Caliper.Entities.Assignable;
	using ImsGlobal.Caliper.Entities.Qti;

	public class AssessmentItem : AssignableDigitalResource, IAssessmentItem {

		public AssessmentItem( string id )
			: base( id ) {
			this.Type = AssignableDigitalResourceType.AssessmentItem;
		}

	}

}
