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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CertificateManager.Model;

namespace Amazon.CertificateManager
{
    /// <summary>
    /// Interface for accessing CertificateManager
    ///
    /// AWS Certificate Manager 
    /// <para>
    /// Welcome to the AWS Certificate Manager (ACM) API documentation.
    /// </para>
    ///  
    /// <para>
    /// You can use ACM to manage SSL/TLS certificates for your AWS-based websites and applications.
    /// For general information about using ACM, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/">
    /// <i>AWS Certificate Manager User Guide</i> </a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCertificateManager : IAmazonService, IDisposable
    {

        
        #region  AddTagsToCertificate


        /// <summary>
        /// Adds one or more tags to an ACM Certificate. Tags are labels that you can use to identify
        /// and organize your AWS resources. Each tag consists of a <code>key</code> and an optional
        /// <code>value</code>. You specify the certificate on input by its Amazon Resource Name
        /// (ARN). You specify the tag by using a key-value pair.
        /// 
        ///  
        /// <para>
        /// You can apply a tag to just one certificate if you want to identify a specific characteristic
        /// of that certificate, or you can apply the same tag to multiple certificates if you
        /// want to filter for a common relationship among those certificates. Similarly, you
        /// can apply the same tag to multiple resources if you want to specify a relationship
        /// among those resources. For example, you can add the same tag to an ACM Certificate
        /// and an Elastic Load Balancing load balancer to indicate that they are both used by
        /// the same website. For more information, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/tags.html">Tagging
        /// ACM Certificates</a>.
        /// </para>
        ///  
        /// <para>
        /// To remove one or more tags, use the <a>RemoveTagsFromCertificate</a> action. To view
        /// all of the tags that have been applied to the certificate, use the <a>ListTagsForCertificate</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToCertificate service method.</param>
        /// 
        /// <returns>The response from the AddTagsToCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <code>aws:</code>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/AddTagsToCertificate">REST API Reference for AddTagsToCertificate Operation</seealso>
        AddTagsToCertificateResponse AddTagsToCertificate(AddTagsToCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/AddTagsToCertificate">REST API Reference for AddTagsToCertificate Operation</seealso>
        IAsyncResult BeginAddTagsToCertificate(AddTagsToCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToCertificate.</param>
        /// 
        /// <returns>Returns a  AddTagsToCertificateResult from CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/AddTagsToCertificate">REST API Reference for AddTagsToCertificate Operation</seealso>
        AddTagsToCertificateResponse EndAddTagsToCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCertificate


        /// <summary>
        /// Deletes an ACM Certificate and its associated private key. If this action succeeds,
        /// the certificate no longer appears in the list of ACM Certificates that can be displayed
        /// by calling the <a>ListCertificates</a> action or be retrieved by calling the <a>GetCertificate</a>
        /// action. The certificate will not be available for use by other AWS services.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM Certificate that is being used by another AWS service. To
        /// delete a certificate that is in use, the certificate association must first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="certificateArn">String that contains the ARN of the ACM Certificate to be deleted. This must be of the form:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another AWS service in the caller's account. Remove the
        /// association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        DeleteCertificateResponse DeleteCertificate(string certificateArn);

        /// <summary>
        /// Deletes an ACM Certificate and its associated private key. If this action succeeds,
        /// the certificate no longer appears in the list of ACM Certificates that can be displayed
        /// by calling the <a>ListCertificates</a> action or be retrieved by calling the <a>GetCertificate</a>
        /// action. The certificate will not be available for use by other AWS services.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM Certificate that is being used by another AWS service. To
        /// delete a certificate that is in use, the certificate association must first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another AWS service in the caller's account. Remove the
        /// association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        IAsyncResult BeginDeleteCertificate(DeleteCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteCertificateResult from CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        DeleteCertificateResponse EndDeleteCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCertificate


        /// <summary>
        /// Returns detailed metadata about the specified ACM Certificate.
        /// </summary>
        /// <param name="certificateArn">The Amazon Resource Name (ARN) of the ACM Certificate. The ARN must have the following form:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        DescribeCertificateResponse DescribeCertificate(string certificateArn);

        /// <summary>
        /// Returns detailed metadata about the specified ACM Certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        IAsyncResult BeginDescribeCertificate(DescribeCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificate.</param>
        /// 
        /// <returns>Returns a  DescribeCertificateResult from CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        DescribeCertificateResponse EndDescribeCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCertificate


        /// <summary>
        /// Retrieves an ACM Certificate and certificate chain for the certificate specified by
        /// an ARN. The chain is an ordered list of certificates that contains the root certificate,
        /// intermediate certificates of subordinate CAs, and the ACM Certificate. The certificate
        /// and certificate chain are base64 encoded. If you want to decode the certificate chain
        /// to see the individual certificate fields, you can use OpenSSL.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, ACM Certificates can be used only with Elastic Load Balancing and Amazon
        /// CloudFront.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="certificateArn">String that contains a certificate ARN in the following format:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        GetCertificateResponse GetCertificate(string certificateArn);

        /// <summary>
        /// Retrieves an ACM Certificate and certificate chain for the certificate specified by
        /// an ARN. The chain is an ordered list of certificates that contains the root certificate,
        /// intermediate certificates of subordinate CAs, and the ACM Certificate. The certificate
        /// and certificate chain are base64 encoded. If you want to decode the certificate chain
        /// to see the individual certificate fields, you can use OpenSSL.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, ACM Certificates can be used only with Elastic Load Balancing and Amazon
        /// CloudFront.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate service method.</param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        GetCertificateResponse GetCertificate(GetCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        IAsyncResult BeginGetCertificate(GetCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCertificate.</param>
        /// 
        /// <returns>Returns a  GetCertificateResult from CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        GetCertificateResponse EndGetCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportCertificate


        /// <summary>
        /// Imports an SSL/TLS certificate into AWS Certificate Manager (ACM) to use with <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-services.html">ACM's
        /// integrated AWS services</a>.
        /// 
        ///  <note> 
        /// <para>
        /// ACM does not provide <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for certificates that you import.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about importing certificates into ACM, including the differences
        /// between certificates that you import and those that ACM provides, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// Certificates</a> in the <i>AWS Certificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To import a certificate, you must provide the certificate and the matching private
        /// key. When the certificate is not self-signed, you must also provide a certificate
        /// chain. You can omit the certificate chain when importing a self-signed certificate.
        /// </para>
        ///  
        /// <para>
        /// The certificate, private key, and certificate chain must be PEM-encoded. For more
        /// information about converting these items to PEM format, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html#import-certificate-troubleshooting">Importing
        /// Certificates Troubleshooting</a> in the <i>AWS Certificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To import a new certificate, omit the <code>CertificateArn</code> field. Include this
        /// field only when you want to replace a previously imported certificate.
        /// </para>
        ///  
        /// <para>
        /// This operation returns the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the imported certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded. For example, you may have input more domains than
        /// are allowed or you've requested too many certificates for your account. See the exception
        /// message returned by ACM to determine which limit you have violated. For more information
        /// about ACM limits, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-limits.html">Limits</a>
        /// topic.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        ImportCertificateResponse ImportCertificate(ImportCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        IAsyncResult BeginImportCertificate(ImportCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCertificate.</param>
        /// 
        /// <returns>Returns a  ImportCertificateResult from CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        ImportCertificateResponse EndImportCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCertificates


        /// <summary>
        /// Retrieves a list of ACM Certificates and the domain name for each. You can optionally
        /// filter the list to return only the certificates that match the specified status.
        /// </summary>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        ListCertificatesResponse ListCertificates();

        /// <summary>
        /// Retrieves a list of ACM Certificates and the domain name for each. You can optionally
        /// filter the list to return only the certificates that match the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        ListCertificatesResponse ListCertificates(ListCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        IAsyncResult BeginListCertificates(ListCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCertificates.</param>
        /// 
        /// <returns>Returns a  ListCertificatesResult from CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        ListCertificatesResponse EndListCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForCertificate


        /// <summary>
        /// Lists the tags that have been applied to the ACM Certificate. Use the certificate's
        /// Amazon Resource Name (ARN) to specify the certificate. To add a tag to an ACM Certificate,
        /// use the <a>AddTagsToCertificate</a> action. To delete a tag, use the <a>RemoveTagsFromCertificate</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForCertificate service method.</param>
        /// 
        /// <returns>The response from the ListTagsForCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListTagsForCertificate">REST API Reference for ListTagsForCertificate Operation</seealso>
        ListTagsForCertificateResponse ListTagsForCertificate(ListTagsForCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListTagsForCertificate">REST API Reference for ListTagsForCertificate Operation</seealso>
        IAsyncResult BeginListTagsForCertificate(ListTagsForCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForCertificate.</param>
        /// 
        /// <returns>Returns a  ListTagsForCertificateResult from CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListTagsForCertificate">REST API Reference for ListTagsForCertificate Operation</seealso>
        ListTagsForCertificateResponse EndListTagsForCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTagsFromCertificate


        /// <summary>
        /// Remove one or more tags from an ACM Certificate. A tag consists of a key-value pair.
        /// If you do not specify the value portion of the tag when calling this function, the
        /// tag will be removed regardless of value. If you specify a value, the tag is removed
        /// only if it is associated with the specified value.
        /// 
        ///  
        /// <para>
        /// To add tags to a certificate, use the <a>AddTagsToCertificate</a> action. To view
        /// all of the tags that have been applied to a specific ACM Certificate, use the <a>ListTagsForCertificate</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromCertificate service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <code>aws:</code>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RemoveTagsFromCertificate">REST API Reference for RemoveTagsFromCertificate Operation</seealso>
        RemoveTagsFromCertificateResponse RemoveTagsFromCertificate(RemoveTagsFromCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RemoveTagsFromCertificate">REST API Reference for RemoveTagsFromCertificate Operation</seealso>
        IAsyncResult BeginRemoveTagsFromCertificate(RemoveTagsFromCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromCertificate.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromCertificateResult from CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RemoveTagsFromCertificate">REST API Reference for RemoveTagsFromCertificate Operation</seealso>
        RemoveTagsFromCertificateResponse EndRemoveTagsFromCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  RequestCertificate


        /// <summary>
        /// Requests an ACM Certificate for use with other AWS services. To request an ACM Certificate,
        /// you must specify the fully qualified domain name (FQDN) for your site. You can also
        /// specify additional FQDNs if users can reach your site by using other names. For each
        /// domain name you specify, email is sent to the domain owner to request approval to
        /// issue the certificate. After receiving approval from the domain owner, the ACM Certificate
        /// is issued. For more information, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/">AWS
        /// Certificate Manager User Guide</a>.
        /// </summary>
        /// <param name="domainName">Fully qualified domain name (FQDN), such as www.example.com, of the site that you want to secure with an ACM Certificate. Use an asterisk (*) to create a wildcard certificate that protects several sites in the same domain. For example, *.example.com protects www.example.com, site.example.com, and images.example.com.</param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded. For example, you may have input more domains than
        /// are allowed or you've requested too many certificates for your account. See the exception
        /// message returned by ACM to determine which limit you have violated. For more information
        /// about ACM limits, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-limits.html">Limits</a>
        /// topic.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        RequestCertificateResponse RequestCertificate(string domainName);

        /// <summary>
        /// Requests an ACM Certificate for use with other AWS services. To request an ACM Certificate,
        /// you must specify the fully qualified domain name (FQDN) for your site. You can also
        /// specify additional FQDNs if users can reach your site by using other names. For each
        /// domain name you specify, email is sent to the domain owner to request approval to
        /// issue the certificate. After receiving approval from the domain owner, the ACM Certificate
        /// is issued. For more information, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/">AWS
        /// Certificate Manager User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate service method.</param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded. For example, you may have input more domains than
        /// are allowed or you've requested too many certificates for your account. See the exception
        /// message returned by ACM to determine which limit you have violated. For more information
        /// about ACM limits, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-limits.html">Limits</a>
        /// topic.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        RequestCertificateResponse RequestCertificate(RequestCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RequestCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        IAsyncResult BeginRequestCertificate(RequestCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RequestCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestCertificate.</param>
        /// 
        /// <returns>Returns a  RequestCertificateResult from CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        RequestCertificateResponse EndRequestCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  ResendValidationEmail


        /// <summary>
        /// Resends the email that requests domain ownership validation. The domain owner or an
        /// authorized representative must approve the ACM Certificate before it can be issued.
        /// The certificate can be approved by clicking a link in the mail to navigate to the
        /// Amazon certificate approval website and then clicking <b>I Approve</b>. However, the
        /// validation email can be blocked by spam filters. Therefore, if you do not receive
        /// the original mail, you can request that the mail be resent within 72 hours of requesting
        /// the ACM Certificate. If more than 72 hours have elapsed since your original request
        /// or since your last attempt to resend validation mail, you must request a new certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail service method.</param>
        /// 
        /// <returns>The response from the ResendValidationEmail service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state. For example, this exception can occur if
        /// the specified domain is not using email validation, or the current certificate status
        /// does not permit the requested operation. See the exception message returned by ACM
        /// to determine which state is not valid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ResendValidationEmail">REST API Reference for ResendValidationEmail Operation</seealso>
        ResendValidationEmailResponse ResendValidationEmail(ResendValidationEmailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResendValidationEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResendValidationEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ResendValidationEmail">REST API Reference for ResendValidationEmail Operation</seealso>
        IAsyncResult BeginResendValidationEmail(ResendValidationEmailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResendValidationEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResendValidationEmail.</param>
        /// 
        /// <returns>Returns a  ResendValidationEmailResult from CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ResendValidationEmail">REST API Reference for ResendValidationEmail Operation</seealso>
        ResendValidationEmailResponse EndResendValidationEmail(IAsyncResult asyncResult);

        #endregion
        
    }
}