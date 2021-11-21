namespace Urkin.Models
{
    /// <summary>
    /// Provides application manager result types constants
    /// </summary>
    public partial class ApplicationManagerResult
    {
        /// <summary>
        /// The type for a failed application manager result
        /// </summary>
        public const string FAIL = "FAIL";
        /// <summary>
        /// The type for a succeeded application manager result
        /// </summary>
        public const string SUCCESS = "SUCCESS";
        /// <summary>
        /// The type for an empty result application manager result
        /// </summary>
        public const string EMPTY_RESULT = "EMPTY_RESULT";
        /// <summary>
        /// The type for an entity created application manager result
        /// </summary>
        public const string ENTITY_CREATED = "ENTITY_CREATED";
        /// <summary>
        /// The type for an entity not found application manager result
        /// </summary>
        public const string ENTITY_NOT_FOUND = "ENTITY_NOT_FOUND";
        /// <summary>
        /// The type for a invalid input data application manager result
        /// </summary>
        public const string INVALID_INPUT_DATA = "INVALID_INPUT_DATA";
    }
}
