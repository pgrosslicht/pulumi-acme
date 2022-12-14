// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";

export interface AcmeCertificateDnsChallenge {
    config?: pulumi.Input<{[key: string]: any}>;
    provider: pulumi.Input<string>;
}

export interface AcmeCertificateHttpChallenge {
    port?: pulumi.Input<number>;
    proxyHeader?: pulumi.Input<string>;
}

export interface AcmeCertificateHttpMemcachedChallenge {
    hosts: pulumi.Input<pulumi.Input<string>[]>;
}

export interface AcmeCertificateHttpWebrootChallenge {
    directory: pulumi.Input<string>;
}

export interface AcmeCertificateTlsChallenge {
    port?: pulumi.Input<number>;
}

export interface AcmeRegistrationExternalAccountBinding {
    hmacBase64: pulumi.Input<string>;
    keyId: pulumi.Input<string>;
}
