// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Acme
{
    [AcmeResourceType("acme:index/acmeCertificate:AcmeCertificate")]
    public partial class AcmeCertificate : global::Pulumi.CustomResource
    {
        [Output("accountKeyPem")]
        public Output<string> AccountKeyPem { get; private set; } = null!;

        [Output("certificateDomain")]
        public Output<string> CertificateDomain { get; private set; } = null!;

        [Output("certificateP12")]
        public Output<string> CertificateP12 { get; private set; } = null!;

        [Output("certificateP12Password")]
        public Output<string?> CertificateP12Password { get; private set; } = null!;

        [Output("certificatePem")]
        public Output<string> CertificatePem { get; private set; } = null!;

        [Output("certificateRequestPem")]
        public Output<string?> CertificateRequestPem { get; private set; } = null!;

        [Output("certificateUrl")]
        public Output<string> CertificateUrl { get; private set; } = null!;

        [Output("commonName")]
        public Output<string?> CommonName { get; private set; } = null!;

        [Output("disableCompletePropagation")]
        public Output<bool?> DisableCompletePropagation { get; private set; } = null!;

        [Output("dnsChallenges")]
        public Output<ImmutableArray<Outputs.AcmeCertificateDnsChallenge>> DnsChallenges { get; private set; } = null!;

        [Output("httpChallenge")]
        public Output<Outputs.AcmeCertificateHttpChallenge?> HttpChallenge { get; private set; } = null!;

        [Output("httpMemcachedChallenge")]
        public Output<Outputs.AcmeCertificateHttpMemcachedChallenge?> HttpMemcachedChallenge { get; private set; } = null!;

        [Output("httpWebrootChallenge")]
        public Output<Outputs.AcmeCertificateHttpWebrootChallenge?> HttpWebrootChallenge { get; private set; } = null!;

        [Output("issuerPem")]
        public Output<string> IssuerPem { get; private set; } = null!;

        [Output("keyType")]
        public Output<string?> KeyType { get; private set; } = null!;

        [Output("minDaysRemaining")]
        public Output<int?> MinDaysRemaining { get; private set; } = null!;

        [Output("mustStaple")]
        public Output<bool?> MustStaple { get; private set; } = null!;

        [Output("preCheckDelay")]
        public Output<int?> PreCheckDelay { get; private set; } = null!;

        [Output("preferredChain")]
        public Output<string?> PreferredChain { get; private set; } = null!;

        [Output("privateKeyPem")]
        public Output<string> PrivateKeyPem { get; private set; } = null!;

        [Output("recursiveNameservers")]
        public Output<ImmutableArray<string>> RecursiveNameservers { get; private set; } = null!;

        [Output("revokeCertificateOnDestroy")]
        public Output<bool?> RevokeCertificateOnDestroy { get; private set; } = null!;

        [Output("subjectAlternativeNames")]
        public Output<ImmutableArray<string>> SubjectAlternativeNames { get; private set; } = null!;

        [Output("tlsChallenge")]
        public Output<Outputs.AcmeCertificateTlsChallenge?> TlsChallenge { get; private set; } = null!;


        /// <summary>
        /// Create a AcmeCertificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AcmeCertificate(string name, AcmeCertificateArgs args, CustomResourceOptions? options = null)
            : base("acme:index/acmeCertificate:AcmeCertificate", name, args ?? new AcmeCertificateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AcmeCertificate(string name, Input<string> id, AcmeCertificateState? state = null, CustomResourceOptions? options = null)
            : base("acme:index/acmeCertificate:AcmeCertificate", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/pgrosslicht/pulumi-acme/releases/",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AcmeCertificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AcmeCertificate Get(string name, Input<string> id, AcmeCertificateState? state = null, CustomResourceOptions? options = null)
        {
            return new AcmeCertificate(name, id, state, options);
        }
    }

    public sealed class AcmeCertificateArgs : global::Pulumi.ResourceArgs
    {
        [Input("accountKeyPem", required: true)]
        public Input<string> AccountKeyPem { get; set; } = null!;

        [Input("certificateP12Password")]
        public Input<string>? CertificateP12Password { get; set; }

        [Input("certificateRequestPem")]
        public Input<string>? CertificateRequestPem { get; set; }

        [Input("commonName")]
        public Input<string>? CommonName { get; set; }

        [Input("disableCompletePropagation")]
        public Input<bool>? DisableCompletePropagation { get; set; }

        [Input("dnsChallenges")]
        private InputList<Inputs.AcmeCertificateDnsChallengeArgs>? _dnsChallenges;
        public InputList<Inputs.AcmeCertificateDnsChallengeArgs> DnsChallenges
        {
            get => _dnsChallenges ?? (_dnsChallenges = new InputList<Inputs.AcmeCertificateDnsChallengeArgs>());
            set => _dnsChallenges = value;
        }

        [Input("httpChallenge")]
        public Input<Inputs.AcmeCertificateHttpChallengeArgs>? HttpChallenge { get; set; }

        [Input("httpMemcachedChallenge")]
        public Input<Inputs.AcmeCertificateHttpMemcachedChallengeArgs>? HttpMemcachedChallenge { get; set; }

        [Input("httpWebrootChallenge")]
        public Input<Inputs.AcmeCertificateHttpWebrootChallengeArgs>? HttpWebrootChallenge { get; set; }

        [Input("keyType")]
        public Input<string>? KeyType { get; set; }

        [Input("minDaysRemaining")]
        public Input<int>? MinDaysRemaining { get; set; }

        [Input("mustStaple")]
        public Input<bool>? MustStaple { get; set; }

        [Input("preCheckDelay")]
        public Input<int>? PreCheckDelay { get; set; }

        [Input("preferredChain")]
        public Input<string>? PreferredChain { get; set; }

        [Input("recursiveNameservers")]
        private InputList<string>? _recursiveNameservers;
        public InputList<string> RecursiveNameservers
        {
            get => _recursiveNameservers ?? (_recursiveNameservers = new InputList<string>());
            set => _recursiveNameservers = value;
        }

        [Input("revokeCertificateOnDestroy")]
        public Input<bool>? RevokeCertificateOnDestroy { get; set; }

        [Input("subjectAlternativeNames")]
        private InputList<string>? _subjectAlternativeNames;
        public InputList<string> SubjectAlternativeNames
        {
            get => _subjectAlternativeNames ?? (_subjectAlternativeNames = new InputList<string>());
            set => _subjectAlternativeNames = value;
        }

        [Input("tlsChallenge")]
        public Input<Inputs.AcmeCertificateTlsChallengeArgs>? TlsChallenge { get; set; }

        public AcmeCertificateArgs()
        {
        }
        public static new AcmeCertificateArgs Empty => new AcmeCertificateArgs();
    }

    public sealed class AcmeCertificateState : global::Pulumi.ResourceArgs
    {
        [Input("accountKeyPem")]
        public Input<string>? AccountKeyPem { get; set; }

        [Input("certificateDomain")]
        public Input<string>? CertificateDomain { get; set; }

        [Input("certificateP12")]
        public Input<string>? CertificateP12 { get; set; }

        [Input("certificateP12Password")]
        public Input<string>? CertificateP12Password { get; set; }

        [Input("certificatePem")]
        public Input<string>? CertificatePem { get; set; }

        [Input("certificateRequestPem")]
        public Input<string>? CertificateRequestPem { get; set; }

        [Input("certificateUrl")]
        public Input<string>? CertificateUrl { get; set; }

        [Input("commonName")]
        public Input<string>? CommonName { get; set; }

        [Input("disableCompletePropagation")]
        public Input<bool>? DisableCompletePropagation { get; set; }

        [Input("dnsChallenges")]
        private InputList<Inputs.AcmeCertificateDnsChallengeGetArgs>? _dnsChallenges;
        public InputList<Inputs.AcmeCertificateDnsChallengeGetArgs> DnsChallenges
        {
            get => _dnsChallenges ?? (_dnsChallenges = new InputList<Inputs.AcmeCertificateDnsChallengeGetArgs>());
            set => _dnsChallenges = value;
        }

        [Input("httpChallenge")]
        public Input<Inputs.AcmeCertificateHttpChallengeGetArgs>? HttpChallenge { get; set; }

        [Input("httpMemcachedChallenge")]
        public Input<Inputs.AcmeCertificateHttpMemcachedChallengeGetArgs>? HttpMemcachedChallenge { get; set; }

        [Input("httpWebrootChallenge")]
        public Input<Inputs.AcmeCertificateHttpWebrootChallengeGetArgs>? HttpWebrootChallenge { get; set; }

        [Input("issuerPem")]
        public Input<string>? IssuerPem { get; set; }

        [Input("keyType")]
        public Input<string>? KeyType { get; set; }

        [Input("minDaysRemaining")]
        public Input<int>? MinDaysRemaining { get; set; }

        [Input("mustStaple")]
        public Input<bool>? MustStaple { get; set; }

        [Input("preCheckDelay")]
        public Input<int>? PreCheckDelay { get; set; }

        [Input("preferredChain")]
        public Input<string>? PreferredChain { get; set; }

        [Input("privateKeyPem")]
        public Input<string>? PrivateKeyPem { get; set; }

        [Input("recursiveNameservers")]
        private InputList<string>? _recursiveNameservers;
        public InputList<string> RecursiveNameservers
        {
            get => _recursiveNameservers ?? (_recursiveNameservers = new InputList<string>());
            set => _recursiveNameservers = value;
        }

        [Input("revokeCertificateOnDestroy")]
        public Input<bool>? RevokeCertificateOnDestroy { get; set; }

        [Input("subjectAlternativeNames")]
        private InputList<string>? _subjectAlternativeNames;
        public InputList<string> SubjectAlternativeNames
        {
            get => _subjectAlternativeNames ?? (_subjectAlternativeNames = new InputList<string>());
            set => _subjectAlternativeNames = value;
        }

        [Input("tlsChallenge")]
        public Input<Inputs.AcmeCertificateTlsChallengeGetArgs>? TlsChallenge { get; set; }

        public AcmeCertificateState()
        {
        }
        public static new AcmeCertificateState Empty => new AcmeCertificateState();
    }
}
