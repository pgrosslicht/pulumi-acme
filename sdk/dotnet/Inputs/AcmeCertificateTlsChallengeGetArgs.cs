// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Acme.Inputs
{

    public sealed class AcmeCertificateTlsChallengeGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("port")]
        public Input<int>? Port { get; set; }

        public AcmeCertificateTlsChallengeGetArgs()
        {
        }
        public static new AcmeCertificateTlsChallengeGetArgs Empty => new AcmeCertificateTlsChallengeGetArgs();
    }
}
