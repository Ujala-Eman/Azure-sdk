// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TextModeration operations.
    /// </summary>
    public partial interface ITextModeration
    {
        /// <summary>
        /// Detect profanity and match against custom and shared blacklists
        /// </summary>
        /// <remarks>
        /// Detects profanity in more than 100 languages and match against
        /// custom and shared blacklists.
        /// </remarks>
        /// <param name='textContentType'>
        /// The content type. Possible values include: 'text/plain',
        /// 'text/html', 'text/xml', 'text/markdown'
        /// </param>
        /// <param name='textContent'>
        /// Content to screen.
        /// </param>
        /// <param name='language'>
        /// Language of the text.
        /// </param>
        /// <param name='autocorrect'>
        /// Autocorrect text.
        /// </param>
        /// <param name='pII'>
        /// Detect personal identifiable information.
        /// </param>
        /// <param name='listId'>
        /// The list Id.
        /// </param>
        /// <param name='classify'>
        /// Classify input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Screen>> ScreenTextWithHttpMessagesAsync(string textContentType, Stream textContent, string language = default(string), bool? autocorrect = false, bool? pII = false, string listId = default(string), bool? classify = false, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This operation will detect the language of given input content.
        /// Returns the &lt;a
        /// href="http://www-01.sil.org/iso639-3/codes.asp"&gt;ISO 639-3
        /// code&lt;/a&gt; for the predominant language comprising the
        /// submitted text. Over 110 languages supported.
        /// </summary>
        /// <param name='textContentType'>
        /// The content type. Possible values include: 'text/plain',
        /// 'text/html', 'text/xml', 'text/markdown'
        /// </param>
        /// <param name='textContent'>
        /// Content to screen.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DetectedLanguage>> DetectLanguageWithHttpMessagesAsync(string textContentType, Stream textContent, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
