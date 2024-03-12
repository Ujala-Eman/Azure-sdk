// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    /// <summary> The address of the result. </summary>
    public partial class MapsAddress
    {
        /// <summary> Initializes a new instance of <see cref="MapsAddress"/>. </summary>
        internal MapsAddress()
        {
            RouteNumbers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MapsAddress"/>. </summary>
        /// <param name="buildingNumber"> The building number on the street. DEPRECATED, use streetNumber instead. </param>
        /// <param name="street"> The street name. DEPRECATED, use streetName instead. </param>
        /// <param name="crossStreet"> The name of the street being crossed. </param>
        /// <param name="streetNumber"> The building number on the street. </param>
        /// <param name="routeNumbers"> The codes used to unambiguously identify the street. </param>
        /// <param name="streetName"> The street name. </param>
        /// <param name="streetNameAndNumber"> The street name and number. </param>
        /// <param name="municipality"> City / Town. </param>
        /// <param name="municipalitySubdivision"> Sub / Super City. </param>
        /// <param name="countryTertiarySubdivision"> Named Area. </param>
        /// <param name="countrySecondarySubdivision"> County. </param>
        /// <param name="countrySubdivision"> State or Province. </param>
        /// <param name="postalCode"> Postal Code / Zip Code. </param>
        /// <param name="extendedPostalCode"> Extended postal code (availability is dependent on the region). </param>
        /// <param name="countryCode"> Country (Note: This is a two-letter code, not a country name.). </param>
        /// <param name="country"> Country name. </param>
        /// <param name="countryCodeIso3"> ISO alpha-3 country code. </param>
        /// <param name="freeformAddress"> An address line formatted according to the formatting rules of a Result's country of origin, or in the case of a country, its full country name. </param>
        /// <param name="countrySubdivisionName"> The full name of a first level of country administrative hierarchy. This field appears only in case countrySubdivision is presented in an abbreviated form. Only supported for USA, Canada, and Great Britain. </param>
        /// <param name="localName"> An address component which represents the name of a geographic area or locality that groups a number of addressable objects for addressing purposes, without being an administrative unit. This field is used to build the `freeformAddress` property. </param>
        /// <param name="boundingBoxInternal"> The bounding box of the location. </param>
        internal MapsAddress(string buildingNumber, string street, string crossStreet, string streetNumber, IReadOnlyList<string> routeNumbers, string streetName, string streetNameAndNumber, string municipality, string municipalitySubdivision, string countryTertiarySubdivision, string countrySecondarySubdivision, string countrySubdivision, string postalCode, string extendedPostalCode, string countryCode, string country, string countryCodeIso3, string freeformAddress, string countrySubdivisionName, string localName, BoundingBoxCompassNotation boundingBoxInternal)
        {
            BuildingNumber = buildingNumber;
            Street = street;
            CrossStreet = crossStreet;
            StreetNumber = streetNumber;
            RouteNumbers = routeNumbers;
            StreetName = streetName;
            StreetNameAndNumber = streetNameAndNumber;
            Municipality = municipality;
            MunicipalitySubdivision = municipalitySubdivision;
            CountryTertiarySubdivision = countryTertiarySubdivision;
            CountrySecondarySubdivision = countrySecondarySubdivision;
            CountrySubdivision = countrySubdivision;
            PostalCode = postalCode;
            ExtendedPostalCode = extendedPostalCode;
            CountryCode = countryCode;
            Country = country;
            CountryCodeIso3 = countryCodeIso3;
            FreeformAddress = freeformAddress;
            CountrySubdivisionName = countrySubdivisionName;
            LocalName = localName;
            BoundingBoxInternal = boundingBoxInternal;
        }

        /// <summary> The building number on the street. DEPRECATED, use streetNumber instead. </summary>
        public string BuildingNumber { get; }
        /// <summary> The street name. DEPRECATED, use streetName instead. </summary>
        public string Street { get; }
        /// <summary> The name of the street being crossed. </summary>
        public string CrossStreet { get; }
        /// <summary> The building number on the street. </summary>
        public string StreetNumber { get; }
        /// <summary> The codes used to unambiguously identify the street. </summary>
        public IReadOnlyList<string> RouteNumbers { get; }
        /// <summary> The street name. </summary>
        public string StreetName { get; }
        /// <summary> The street name and number. </summary>
        public string StreetNameAndNumber { get; }
        /// <summary> City / Town. </summary>
        public string Municipality { get; }
        /// <summary> Sub / Super City. </summary>
        public string MunicipalitySubdivision { get; }
        /// <summary> Named Area. </summary>
        public string CountryTertiarySubdivision { get; }
        /// <summary> County. </summary>
        public string CountrySecondarySubdivision { get; }
        /// <summary> State or Province. </summary>
        public string CountrySubdivision { get; }
        /// <summary> Postal Code / Zip Code. </summary>
        public string PostalCode { get; }
        /// <summary> Extended postal code (availability is dependent on the region). </summary>
        public string ExtendedPostalCode { get; }
        /// <summary> Country (Note: This is a two-letter code, not a country name.). </summary>
        public string CountryCode { get; }
        /// <summary> Country name. </summary>
        public string Country { get; }
        /// <summary> An address line formatted according to the formatting rules of a Result's country of origin, or in the case of a country, its full country name. </summary>
        public string FreeformAddress { get; }
        /// <summary> The full name of a first level of country administrative hierarchy. This field appears only in case countrySubdivision is presented in an abbreviated form. Only supported for USA, Canada, and Great Britain. </summary>
        public string CountrySubdivisionName { get; }
        /// <summary> An address component which represents the name of a geographic area or locality that groups a number of addressable objects for addressing purposes, without being an administrative unit. This field is used to build the `freeformAddress` property. </summary>
        public string LocalName { get; }
    }
}
