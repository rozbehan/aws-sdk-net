/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the GetDashboardEmbedUrl operation.
    /// Generates an embedded URL and authorization code. Before this can work properly, you
    /// need to configure the dashboards and user permissions first.
    /// </summary>
    public partial class GetDashboardEmbedUrlRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _dashboardId;
        private IdentityType _identityType;
        private bool? _resetDisabled;
        private long? _sessionLifetimeInMinutes;
        private bool? _undoRedoDisabled;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// AWS account ID that contains the dashboard you are embedding.
        /// </para>
        /// </summary>
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID for the dashboard, also added to IAM policy
        /// </para>
        /// </summary>
        public string DashboardId
        {
            get { return this._dashboardId; }
            set { this._dashboardId = value; }
        }

        // Check to see if DashboardId property is set
        internal bool IsSetDashboardId()
        {
            return this._dashboardId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The authentication method the user uses to sign in (IAM or QUICKSIGHT).
        /// </para>
        /// </summary>
        public IdentityType IdentityType
        {
            get { return this._identityType; }
            set { this._identityType = value; }
        }

        // Check to see if IdentityType property is set
        internal bool IsSetIdentityType()
        {
            return this._identityType != null;
        }

        /// <summary>
        /// Gets and sets the property ResetDisabled. 
        /// <para>
        /// Remove the reset button on embedded dashboard. The default is FALSE, which allows
        /// the reset button.
        /// </para>
        /// </summary>
        public bool ResetDisabled
        {
            get { return this._resetDisabled.GetValueOrDefault(); }
            set { this._resetDisabled = value; }
        }

        // Check to see if ResetDisabled property is set
        internal bool IsSetResetDisabled()
        {
            return this._resetDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionLifetimeInMinutes. 
        /// <para>
        /// How many minutes the session is valid. The session lifetime must be between 15 and
        /// 600 minutes.
        /// </para>
        /// </summary>
        public long SessionLifetimeInMinutes
        {
            get { return this._sessionLifetimeInMinutes.GetValueOrDefault(); }
            set { this._sessionLifetimeInMinutes = value; }
        }

        // Check to see if SessionLifetimeInMinutes property is set
        internal bool IsSetSessionLifetimeInMinutes()
        {
            return this._sessionLifetimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UndoRedoDisabled. 
        /// <para>
        /// Remove the undo/redo button on embedded dashboard. The default is FALSE, which enables
        /// the undo/redo button.
        /// </para>
        /// </summary>
        public bool UndoRedoDisabled
        {
            get { return this._undoRedoDisabled.GetValueOrDefault(); }
            set { this._undoRedoDisabled = value; }
        }

        // Check to see if UndoRedoDisabled property is set
        internal bool IsSetUndoRedoDisabled()
        {
            return this._undoRedoDisabled.HasValue; 
        }

    }
}