﻿namespace CityJSON
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CityJSON specifications v1.0.1, generated on https://quicktype.io/csharp using https://3d.bk.tudelft.nl/schemas/cityjson/1.0.1/cityjson.min.schema.json
    /// </summary>
    /// 
    /// renamed from: 'Coordinate'
    public partial class CityJSONRoot
    {
        [JsonProperty("appearance", NullValueHandling = NullValueHandling.Ignore)]
        public Appearance Appearance { get; set; }

        [JsonProperty("CityObjects")]
        public Dictionary<string, CityObjectValue> CityObjects { get; set; }

        [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Extension> Extensions { get; set; }

        [JsonProperty("geometry-templates", NullValueHandling = NullValueHandling.Ignore)]
        public GeometryTemplates GeometryTemplates { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        [JsonProperty("transform", NullValueHandling = NullValueHandling.Ignore)]
        public Transform Transform { get; set; }

        [JsonProperty("type")]
        public CoordinateType Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("vertices")]
        public List<List<double>> Vertices { get; set; }
    }

    public partial class Appearance
    {
        [JsonProperty("default-theme-material", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultThemeMaterial { get; set; }

        [JsonProperty("default-theme-texture", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultThemeTexture { get; set; }

        [JsonProperty("materials", NullValueHandling = NullValueHandling.Ignore)]
        public List<MaterialElement> Materials { get; set; }

        [JsonProperty("textures", NullValueHandling = NullValueHandling.Ignore)]
        public List<TextureElement> Textures { get; set; }

        [JsonProperty("vertices-texture", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<double>> VerticesTexture { get; set; }
    }

    public partial class MaterialElement
    {
        [JsonProperty("ambientIntensity", NullValueHandling = NullValueHandling.Ignore)]
        public double? AmbientIntensity { get; set; }

        [JsonProperty("diffuseColor", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> DiffuseColor { get; set; }

        [JsonProperty("emissiveColor", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> EmissiveColor { get; set; }

        [JsonProperty("isSmooth", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSmooth { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shininess", NullValueHandling = NullValueHandling.Ignore)]
        public double? Shininess { get; set; }

        [JsonProperty("specularColor", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> SpecularColor { get; set; }

        [JsonProperty("transparency", NullValueHandling = NullValueHandling.Ignore)]
        public double? Transparency { get; set; }
    }

    public partial class TextureElement
    {
        [JsonProperty("borderColor", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> BorderColor { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        [JsonProperty("textureType", NullValueHandling = NullValueHandling.Ignore)]
        public TextureTypeEnum? TextureType { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TextureType? Type { get; set; }

        [JsonProperty("wrapMode", NullValueHandling = NullValueHandling.Ignore)]
        public WrapMode? WrapMode { get; set; }
    }

    public partial class CityObjectClass
    {
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Attributes Attributes { get; set; }

        /// <summary>
        /// the IDs of children
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Children { get; set; }

        [JsonProperty("geographicalExtent", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> GeographicalExtent { get; set; }

        /// <summary>
        /// the IDs of the parents
        /// </summary>
        [JsonProperty("parents", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Parents { get; set; }

        [JsonProperty("geometry", NullValueHandling = NullValueHandling.Ignore)]
        public List<Geometry> Geometry { get; set; }

        /// <summary>
        /// the IDs of the CityObjects members of that group
        /// </summary>
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Members { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Address Address { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("CountryName", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; set; }

        [JsonProperty("LocalityName", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalityName { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }

        [JsonProperty("PostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        [JsonProperty("ThoroughfareName", NullValueHandling = NullValueHandling.Ignore)]
        public string ThoroughfareName { get; set; }

        [JsonProperty("ThoroughfareNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string ThoroughfareNumber { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("boundaries")]
        public List<long> Boundaries { get; set; }

        [JsonProperty("lod")]
        [JsonConverter(typeof(MinMaxValueCheckConverter))]
        public double Lod { get; set; }

        [JsonProperty("type")]
        public LocationType Type { get; set; }
    }

    public partial class Attributes
    {
        [JsonProperty("class", NullValueHandling = NullValueHandling.Ignore)]
        public string Class { get; set; }

        [JsonProperty("creationDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreationDate { get; set; }

        [JsonProperty("function", NullValueHandling = NullValueHandling.Ignore)]
        public string Function { get; set; }

        [JsonProperty("terminationDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TerminationDate { get; set; }

        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public string Usage { get; set; }

        [JsonProperty("measuredHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? MeasuredHeight { get; set; }

        [JsonProperty("roofType", NullValueHandling = NullValueHandling.Ignore)]
        public string RoofType { get; set; }

        [JsonProperty("storeyHeightsAboveGround", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> StoreyHeightsAboveGround { get; set; }

        [JsonProperty("storeyHeightsBelowGround", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> StoreyHeightsBelowGround { get; set; }

        [JsonProperty("storeysAboveGround", NullValueHandling = NullValueHandling.Ignore)]
        public long? StoreysAboveGround { get; set; }

        [JsonProperty("storeysBelowGround", NullValueHandling = NullValueHandling.Ignore)]
        public long? StoreysBelowGround { get; set; }

        [JsonProperty("yearOfConstruction", NullValueHandling = NullValueHandling.Ignore)]
        public long? YearOfConstruction { get; set; }

        [JsonProperty("yearOfDemolition", NullValueHandling = NullValueHandling.Ignore)]
        public long? YearOfDemolition { get; set; }

        [JsonProperty("surfaceMaterial", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SurfaceMaterial { get; set; }

        [JsonProperty("crownDiameter", NullValueHandling = NullValueHandling.Ignore)]
        public double? CrownDiameter { get; set; }

        [JsonProperty("species", NullValueHandling = NullValueHandling.Ignore)]
        public string Species { get; set; }

        [JsonProperty("trunkDiameter", NullValueHandling = NullValueHandling.Ignore)]
        public double? TrunkDiameter { get; set; }

        [JsonProperty("averageHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageHeight { get; set; }

        [JsonProperty("isMovable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMovable { get; set; }
    }

    public partial class Geometry
    {
        [JsonProperty("boundaries")]
        public List<GeometryBoundary> Boundaries { get; set; }

        [JsonProperty("lod", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(MinMaxValueCheckConverter))]
        public double? Lod { get; set; }

        [JsonProperty("type")]
        public GeometryType Type { get; set; }

        [JsonProperty("material", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, GeometryMaterial> Material { get; set; }

        [JsonProperty("semantics", NullValueHandling = NullValueHandling.Ignore)]
        public GeometrySemantics Semantics { get; set; }

        [JsonProperty("texture", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, GeometryTexture> Texture { get; set; }

        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public long? Template { get; set; }

        [JsonProperty("transformationMatrix", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> TransformationMatrix { get; set; }
    }

    public partial class GeometryMaterial
    {
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public partial class GeometrySemantics
    {
        [JsonProperty("surfaces")]
        public List<PurpleSurface> Surfaces { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public partial class PurpleSurface
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class GeometryTexture
    {
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<List<MaterialValue>>> Values { get; set; }
    }

    public partial class Extension
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public partial class GeometryTemplates
    {
        [JsonProperty("templates")]
        public List<Template> Templates { get; set; }

        [JsonProperty("vertices-templates")]
        public List<List<double>> VerticesTemplates { get; set; }
    }

    public partial class Template
    {
        [JsonProperty("boundaries")]
        public List<GeometryBoundary> Boundaries { get; set; }

        [JsonProperty("lod")]
        [JsonConverter(typeof(MinMaxValueCheckConverter))]
        public double Lod { get; set; }

        [JsonProperty("type")]
        public TemplateType Type { get; set; }

        [JsonProperty("material", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TemplateMaterial> Material { get; set; }

        [JsonProperty("semantics", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateSemantics Semantics { get; set; }

        [JsonProperty("texture", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TemplateTexture> Texture { get; set; }
    }

    public partial class TemplateMaterial
    {
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public partial class TemplateSemantics
    {
        [JsonProperty("surfaces")]
        public List<FluffySurface> Surfaces { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public partial class FluffySurface
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class TemplateTexture
    {
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<List<MaterialValue>>> Values { get; set; }
    }

    public partial class Metadata
    {
        [JsonProperty("abstract", NullValueHandling = NullValueHandling.Ignore)]
        public string Abstract { get; set; }

        [JsonProperty("cityfeatureMetadata", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadata CityfeatureMetadata { get; set; }

        [JsonProperty("citymodelIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public string CitymodelIdentifier { get; set; }

        [JsonProperty("constraints", NullValueHandling = NullValueHandling.Ignore)]
        public Constraints Constraints { get; set; }

        [JsonProperty("datasetCharacterSet", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetCharacterSet { get; set; }

        [JsonProperty("datasetLanguage", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetLanguage { get; set; }

        [JsonProperty("datasetPointOfContact", NullValueHandling = NullValueHandling.Ignore)]
        public DatasetPointOfContact DatasetPointOfContact { get; set; }

        [JsonProperty("datasetReferenceDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DatasetReferenceDate { get; set; }

        [JsonProperty("datasetTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetTitle { get; set; }

        /// <summary>
        /// from ISO19115 codelist
        /// </summary>
        [JsonProperty("datasetTopicCategory", NullValueHandling = NullValueHandling.Ignore)]
        public DatasetTopicCategory? DatasetTopicCategory { get; set; }

        [JsonProperty("distributionFormatVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributionFormatVersion { get; set; }

        [JsonProperty("fileIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public string FileIdentifier { get; set; }

        [JsonProperty("geographicalExtent", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> GeographicalExtent { get; set; }

        /// <summary>
        /// the name of the area for instance
        /// </summary>
        [JsonProperty("geographicLocation", NullValueHandling = NullValueHandling.Ignore)]
        public string GeographicLocation { get; set; }

        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keywords { get; set; }

        [JsonProperty("lineage", NullValueHandling = NullValueHandling.Ignore)]
        public List<Lineage> Lineage { get; set; }

        [JsonProperty("materials", NullValueHandling = NullValueHandling.Ignore)]
        public Materials? Materials { get; set; }

        [JsonProperty("metadataCharacterSet", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataCharacterSet { get; set; }

        [JsonProperty("metadataDateStamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? MetadataDateStamp { get; set; }

        [JsonProperty("metadataLanguage", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataLanguage { get; set; }

        [JsonProperty("metadataPointOfContact", NullValueHandling = NullValueHandling.Ignore)]
        public MetadataPointOfContact MetadataPointOfContact { get; set; }

        [JsonProperty("metadataStandard", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataStandard { get; set; }

        [JsonProperty("metadataStandardVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataStandardVersion { get; set; }

        [JsonProperty("onlineResource", NullValueHandling = NullValueHandling.Ignore)]
        public Uri OnlineResource { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public MetadataPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("referenceSystem", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceSystem { get; set; }

        /// <summary>
        /// from ISO19115 codelist
        /// </summary>
        [JsonProperty("spatialRepresentationType", NullValueHandling = NullValueHandling.Ignore)]
        public SpatialRepresentationType? SpatialRepresentationType { get; set; }

        [JsonProperty("specificUsage", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecificUsage { get; set; }

        [JsonProperty("temporalExtent", NullValueHandling = NullValueHandling.Ignore)]
        public TemporalExtent TemporalExtent { get; set; }

        [JsonProperty("textures", NullValueHandling = NullValueHandling.Ignore)]
        public Materials? Textures { get; set; }

        [JsonProperty("thematicModels", NullValueHandling = NullValueHandling.Ignore)]
        public List<ThematicModel> ThematicModels { get; set; }
    }

    public partial class CityfeatureMetadata
    {
        [JsonProperty("Bridge", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataBridge Bridge { get; set; }

        [JsonProperty("Building", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataBuilding Building { get; set; }

        [JsonProperty("CityFurniture", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataCityFurniture CityFurniture { get; set; }

        [JsonProperty("CityObjectGroup", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroup CityObjectGroup { get; set; }

        [JsonProperty("GenericCityObject", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataGenericCityObject GenericCityObject { get; set; }

        [JsonProperty("LandUse", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataLandUse LandUse { get; set; }

        [JsonProperty("PlantCover", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataPlantCover PlantCover { get; set; }

        [JsonProperty("Railway", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataRailway Railway { get; set; }

        [JsonProperty("Road", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataRoad Road { get; set; }

        [JsonProperty("SolitaryVegetationObject", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataSolitaryVegetationObject SolitaryVegetationObject { get; set; }

        [JsonProperty("TINRelief", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataTinRelief TinRelief { get; set; }

        [JsonProperty("TransportSquare", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataTransportSquare TransportSquare { get; set; }

        [JsonProperty("Tunnel", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataTunnel Tunnel { get; set; }

        [JsonProperty("WaterBody", NullValueHandling = NullValueHandling.Ignore)]
        public CityfeatureMetadataWaterBody WaterBody { get; set; }
    }

    public partial class CityfeatureMetadataBridge
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PurplePresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PurplePresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataBuilding
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class FluffyPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataCityFurniture
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public TentacledPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class TentacledPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroup
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("Bridge", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupBridge Bridge { get; set; }

        [JsonProperty("Building", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupBuilding Building { get; set; }

        [JsonProperty("CityFurniture", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupCityFurniture CityFurniture { get; set; }

        [JsonProperty("GenericCityObject", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupGenericCityObject GenericCityObject { get; set; }

        [JsonProperty("LandUse", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupLandUse LandUse { get; set; }

        [JsonProperty("PlantCover", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupPlantCover PlantCover { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("Railway", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupRailway Railway { get; set; }

        [JsonProperty("Road", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupRoad Road { get; set; }

        [JsonProperty("SolitaryVegetationObject", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupSolitaryVegetationObject SolitaryVegetationObject { get; set; }

        [JsonProperty("TINRelief", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupTinRelief TinRelief { get; set; }

        [JsonProperty("TransportSquare", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupTransportSquare TransportSquare { get; set; }

        [JsonProperty("Tunnel", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupTunnel Tunnel { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }

        [JsonProperty("WaterBody", NullValueHandling = NullValueHandling.Ignore)]
        public CityObjectGroupWaterBody WaterBody { get; set; }
    }

    public partial class CityObjectGroupBridge
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public StickyPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class StickyPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupBuilding
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public IndigoPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class IndigoPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupCityFurniture
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public IndecentPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class IndecentPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupGenericCityObject
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public HilariousPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class HilariousPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupLandUse
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public AmbitiousPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class AmbitiousPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupPlantCover
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public CunningPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class CunningPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupRailway
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public MagentaPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class MagentaPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupRoad
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public FriskyPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class FriskyPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupSolitaryVegetationObject
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public MischievousPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class MischievousPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupTinRelief
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public BraggadociousPresentLoDs PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class BraggadociousPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupTransportSquare
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs1 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs1
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupTunnel
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs2 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs2
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityObjectGroupWaterBody
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs3 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs3
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataGenericCityObject
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs4 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs4
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataLandUse
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs5 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs5
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataPlantCover
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs6 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs6
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataRailway
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs7 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs7
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataRoad
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs8 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs8
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataSolitaryVegetationObject
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs9 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs9
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataTinRelief
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs10 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs10
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataTransportSquare
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs11 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs11
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataTunnel
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs12 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs12
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class CityfeatureMetadataWaterBody
    {
        [JsonProperty("aggregateFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? AggregateFeatureCount { get; set; }

        [JsonProperty("presentLoDs", NullValueHandling = NullValueHandling.Ignore)]
        public PresentLoDs13 PresentLoDs { get; set; }

        [JsonProperty("uniqueFeatureCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueFeatureCount { get; set; }
    }

    public partial class PresentLoDs13
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class Constraints
    {
        [JsonProperty("legalConstraints", NullValueHandling = NullValueHandling.Ignore)]
        public LegalConstraints? LegalConstraints { get; set; }

        [JsonProperty("securityConstraints", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityConstraints? SecurityConstraints { get; set; }

        [JsonProperty("userNote", NullValueHandling = NullValueHandling.Ignore)]
        public string UserNote { get; set; }
    }

    public partial class DatasetPointOfContact
    {
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("contactName", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        [JsonProperty("emailAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("contactType")]
        public ContactType ContactType { get; set; }

        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        /// <summary>
        /// from ISO 19115 codelist
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Role? Role { get; set; }

        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Website { get; set; }
    }

    public partial class Lineage
    {
        [JsonProperty("additionalDocumentation", NullValueHandling = NullValueHandling.Ignore)]
        public Uri AdditionalDocumentation { get; set; }

        [JsonProperty("featureIDs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FeatureIDs { get; set; }

        [JsonProperty("processStep", NullValueHandling = NullValueHandling.Ignore)]
        public ProcessStep ProcessStep { get; set; }

        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public List<Source> Source { get; set; }

        [JsonProperty("statement", NullValueHandling = NullValueHandling.Ignore)]
        public string Statement { get; set; }

        [JsonProperty("thematicModels", NullValueHandling = NullValueHandling.Ignore)]
        public List<ThematicModel> ThematicModels { get; set; }
    }

    public partial class ProcessStep
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("processor", NullValueHandling = NullValueHandling.Ignore)]
        public Processor Processor { get; set; }

        [JsonProperty("rationale", NullValueHandling = NullValueHandling.Ignore)]
        public string Rationale { get; set; }

        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Reference { get; set; }

        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        [JsonProperty("stepDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StepDateTime { get; set; }
    }

    public partial class Processor
    {
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("contactName", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        [JsonProperty("emailAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("contactType")]
        public ContactType ContactType { get; set; }

        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        /// <summary>
        /// from ISO 19115 codelist
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Role? Role { get; set; }

        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Website { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        [JsonProperty("sourceCitation", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SourceCitation { get; set; }

        [JsonProperty("sourceMetadata", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SourceMetadata { get; set; }

        [JsonProperty("sourceReferenceSystem", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceReferenceSystem { get; set; }

        [JsonProperty("sourceSpatialResolution", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceSpatialResolution { get; set; }
    }

    public partial class MetadataPointOfContact
    {
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("contactName", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        [JsonProperty("emailAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("contactType")]
        public ContactType ContactType { get; set; }

        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        /// <summary>
        /// from ISO 19115 codelist
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Role? Role { get; set; }

        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Website { get; set; }
    }

    public partial class MetadataPresentLoDs
    {
        [JsonProperty("0.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The00 { get; set; }

        [JsonProperty("0.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The01 { get; set; }

        [JsonProperty("0.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The02 { get; set; }

        [JsonProperty("0.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The03 { get; set; }

        [JsonProperty("1.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The10 { get; set; }

        [JsonProperty("1.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The11 { get; set; }

        [JsonProperty("1.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The12 { get; set; }

        [JsonProperty("1.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The13 { get; set; }

        [JsonProperty("2.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The20 { get; set; }

        [JsonProperty("2.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The21 { get; set; }

        [JsonProperty("2.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The22 { get; set; }

        [JsonProperty("2.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The23 { get; set; }

        [JsonProperty("3.0", NullValueHandling = NullValueHandling.Ignore)]
        public long? The30 { get; set; }

        [JsonProperty("3.1", NullValueHandling = NullValueHandling.Ignore)]
        public long? The31 { get; set; }

        [JsonProperty("3.2", NullValueHandling = NullValueHandling.Ignore)]
        public long? The32 { get; set; }

        [JsonProperty("3.3", NullValueHandling = NullValueHandling.Ignore)]
        public long? The33 { get; set; }
    }

    public partial class TemporalExtent
    {
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }
    }

    public partial class Transform
    {
        [JsonProperty("scale")]
        public List<double> Scale { get; set; }

        [JsonProperty("translate")]
        public List<double> Translate { get; set; }
    }

    public enum TextureTypeEnum { Specific, Typical, Unknown };

    public enum TextureType { Jpg, Png };

    public enum WrapMode { Border, Clamp, Mirror, None, Wrap };

    public enum LocationType { MultiPoint };

    public enum GeometryType { CompositeSolid, CompositeSurface, GeometryInstance, MultiLineString, MultiPoint, MultiSolid, MultiSurface, Solid };

    public enum TemplateType { CompositeSolid, CompositeSurface, MultiLineString, MultiPoint, MultiSolid, MultiSurface, Solid };

    public enum LegalConstraints { Confidential, Copyright, InConfidence, IntellectualPropertyRights, Licence, LicenseDistributor, LicenseEndUser, LicenseUnrestricted, OtherRestrictions, Patent, PatentPending, Private, Restricted, SensitiveButUnclassified, Statutory, Trademark, Unrestricted };

    public enum SecurityConstraints { Confidential, ForOfficialUseOnly, LimitedDistribution, Protected, Restricted, Secret, SensitiveButUnclassified, TopSecret, Unclassified };

    public enum ContactType { Individual, Organization };

    /// <summary>
    /// from ISO 19115 codelist
    /// </summary>
    public enum Role { Author, CoAuthor, Collaborator, Contributor, Custodian, Distributor, Editor, Funder, Mediator, Originator, Owner, PointOfContact, PrincipalInvestigator, Processor, Publisher, ResourceProvider, RightsHolder, Sponsor, Stakeholder, User };

    /// <summary>
    /// from ISO19115 codelist
    /// </summary>
    public enum DatasetTopicCategory { Atmosphere, Bioata, Boundaries, Climatology, Disaster, Economy, Elevation, Environment, ExtraTerrestrial, Farming, GeoscientificInformation, Health, ImageryBaseMapsEarthCover, InlandWaters, IntelligenceMilitary, Location, Meteorology, Oceans, PlanningCadastre, Society, Structure, Transportation, UtilitiesCommunication };

    public enum ThematicModel { Bridge, Building, CityFurniture, CityObjectGroup, GenericCityObject, LandUse, PlantCover, Railway, Road, SolitaryVegetationObject, TinRelief, TransportSquare, Tunnel, WaterBody };

    public enum Materials { Absent, Present };

    /// <summary>
    /// from ISO19115 codelist
    /// </summary>
    public enum SpatialRepresentationType { Grid, StereoModel, TextTable, Tin, Vector, Video };

    public enum CoordinateType { CityJson };

    public partial struct PurpleBoundary
    {
        public long? Integer;
        public List<long> IntegerArray;

        public static implicit operator PurpleBoundary(long Integer) => new PurpleBoundary { Integer = Integer };
        public static implicit operator PurpleBoundary(List<long> IntegerArray) => new PurpleBoundary { IntegerArray = IntegerArray };
    }

    public partial struct FluffyBoundary
    {
        public List<PurpleBoundary> AnythingArray;
        public long? Integer;

        public static implicit operator FluffyBoundary(List<PurpleBoundary> AnythingArray) => new FluffyBoundary { AnythingArray = AnythingArray };
        public static implicit operator FluffyBoundary(long Integer) => new FluffyBoundary { Integer = Integer };
    }

    public partial struct TentacledBoundary
    {
        public List<FluffyBoundary> AnythingArray;
        public long? Integer;

        public static implicit operator TentacledBoundary(List<FluffyBoundary> AnythingArray) => new TentacledBoundary { AnythingArray = AnythingArray };
        public static implicit operator TentacledBoundary(long Integer) => new TentacledBoundary { Integer = Integer };
    }

    public partial struct GeometryBoundary
    {
        public List<TentacledBoundary> AnythingArray;
        public long? Integer;

        public static implicit operator GeometryBoundary(List<TentacledBoundary> AnythingArray) => new GeometryBoundary { AnythingArray = AnythingArray };
        public static implicit operator GeometryBoundary(long Integer) => new GeometryBoundary { Integer = Integer };
    }

    public partial struct ValueValue
    {
        public long? Integer;
        public List<long?> UnionArray;

        public static implicit operator ValueValue(long Integer) => new ValueValue { Integer = Integer };
        public static implicit operator ValueValue(List<long?> UnionArray) => new ValueValue { UnionArray = UnionArray };
        public bool IsNull => UnionArray == null && Integer == null;
    }

    public partial struct MaterialValue
    {
        public List<ValueValue> AnythingArray;
        public long? Integer;

        public static implicit operator MaterialValue(List<ValueValue> AnythingArray) => new MaterialValue { AnythingArray = AnythingArray };
        public static implicit operator MaterialValue(long Integer) => new MaterialValue { Integer = Integer };
        public bool IsNull => AnythingArray == null && Integer == null;
    }

    public partial struct CityObjectValue
    {
        public List<object> AnythingArray;
        public bool? Bool;
        public CityObjectClass CityObjectClass;
        public double? Double;
        public long? Integer;
        public string String;

        public static implicit operator CityObjectValue(List<object> AnythingArray) => new CityObjectValue { AnythingArray = AnythingArray };
        public static implicit operator CityObjectValue(bool Bool) => new CityObjectValue { Bool = Bool };
        public static implicit operator CityObjectValue(CityObjectClass CityObjectClass) => new CityObjectValue { CityObjectClass = CityObjectClass };
        public static implicit operator CityObjectValue(double Double) => new CityObjectValue { Double = Double };
        public static implicit operator CityObjectValue(long Integer) => new CityObjectValue { Integer = Integer };
        public static implicit operator CityObjectValue(string String) => new CityObjectValue { String = String };
        public bool IsNull => AnythingArray == null && Bool == null && CityObjectClass == null && Double == null && Integer == null && String == null;
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CityObjectValueConverter.Singleton,
                LocationTypeConverter.Singleton,
                GeometryBoundaryConverter.Singleton,
                TentacledBoundaryConverter.Singleton,
                FluffyBoundaryConverter.Singleton,
                PurpleBoundaryConverter.Singleton,
                MaterialValueConverter.Singleton,
                ValueValueConverter.Singleton,
                GeometryTypeConverter.Singleton,
                TextureTypeEnumConverter.Singleton,
                TextureTypeConverter.Singleton,
                WrapModeConverter.Singleton,
                TemplateTypeConverter.Singleton,
                LegalConstraintsConverter.Singleton,
                SecurityConstraintsConverter.Singleton,
                ContactTypeConverter.Singleton,
                RoleConverter.Singleton,
                DatasetTopicCategoryConverter.Singleton,
                ThematicModelConverter.Singleton,
                MaterialsConverter.Singleton,
                SpatialRepresentationTypeConverter.Singleton,
                CoordinateTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CityObjectValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CityObjectValue) || t == typeof(CityObjectValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new CityObjectValue { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new CityObjectValue { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new CityObjectValue { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new CityObjectValue { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new CityObjectValue { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<CityObjectClass>(reader);
                    return new CityObjectValue { CityObjectClass = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new CityObjectValue { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type CityObjectValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CityObjectValue)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.CityObjectClass != null)
            {
                serializer.Serialize(writer, value.CityObjectClass);
                return;
            }
            throw new Exception("Cannot marshal type CityObjectValue");
        }

        public static readonly CityObjectValueConverter Singleton = new CityObjectValueConverter();
    }

    internal class MinMaxValueCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(double) || t == typeof(double?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<double>(reader);
            if (value >= 0 && value <= 3.5)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type double");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (double)untypedValue;
            if (value >= 0 && value <= 3.5)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type double");
        }

        public static readonly MinMaxValueCheckConverter Singleton = new MinMaxValueCheckConverter();
    }

    internal class LocationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LocationType) || t == typeof(LocationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "MultiPoint")
            {
                return LocationType.MultiPoint;
            }
            throw new Exception("Cannot unmarshal type LocationType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LocationType)untypedValue;
            if (value == LocationType.MultiPoint)
            {
                serializer.Serialize(writer, "MultiPoint");
                return;
            }
            throw new Exception("Cannot marshal type LocationType");
        }

        public static readonly LocationTypeConverter Singleton = new LocationTypeConverter();
    }

    internal class GeometryBoundaryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GeometryBoundary) || t == typeof(GeometryBoundary?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new GeometryBoundary { Integer = integerValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TentacledBoundary>>(reader);
                    return new GeometryBoundary { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type GeometryBoundary");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (GeometryBoundary)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            throw new Exception("Cannot marshal type GeometryBoundary");
        }

        public static readonly GeometryBoundaryConverter Singleton = new GeometryBoundaryConverter();
    }

    internal class TentacledBoundaryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TentacledBoundary) || t == typeof(TentacledBoundary?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new TentacledBoundary { Integer = integerValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<FluffyBoundary>>(reader);
                    return new TentacledBoundary { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TentacledBoundary");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TentacledBoundary)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            throw new Exception("Cannot marshal type TentacledBoundary");
        }

        public static readonly TentacledBoundaryConverter Singleton = new TentacledBoundaryConverter();
    }

    internal class FluffyBoundaryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyBoundary) || t == typeof(FluffyBoundary?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new FluffyBoundary { Integer = integerValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<PurpleBoundary>>(reader);
                    return new FluffyBoundary { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type FluffyBoundary");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FluffyBoundary)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            throw new Exception("Cannot marshal type FluffyBoundary");
        }

        public static readonly FluffyBoundaryConverter Singleton = new FluffyBoundaryConverter();
    }

    internal class PurpleBoundaryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleBoundary) || t == typeof(PurpleBoundary?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new PurpleBoundary { Integer = integerValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<long>>(reader);
                    return new PurpleBoundary { IntegerArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PurpleBoundary");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PurpleBoundary)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.IntegerArray != null)
            {
                serializer.Serialize(writer, value.IntegerArray);
                return;
            }
            throw new Exception("Cannot marshal type PurpleBoundary");
        }

        public static readonly PurpleBoundaryConverter Singleton = new PurpleBoundaryConverter();
    }

    internal class MaterialValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MaterialValue) || t == typeof(MaterialValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new MaterialValue { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new MaterialValue { Integer = integerValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ValueValue>>(reader);
                    return new MaterialValue { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type MaterialValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (MaterialValue)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            throw new Exception("Cannot marshal type MaterialValue");
        }

        public static readonly MaterialValueConverter Singleton = new MaterialValueConverter();
    }

    internal class ValueValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueValue) || t == typeof(ValueValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new ValueValue { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new ValueValue { Integer = integerValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<long?>>(reader);
                    return new ValueValue { UnionArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ValueValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ValueValue)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.UnionArray != null)
            {
                serializer.Serialize(writer, value.UnionArray);
                return;
            }
            throw new Exception("Cannot marshal type ValueValue");
        }

        public static readonly ValueValueConverter Singleton = new ValueValueConverter();
    }

    internal class GeometryTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GeometryType) || t == typeof(GeometryType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CompositeSolid":
                    return GeometryType.CompositeSolid;
                case "CompositeSurface":
                    return GeometryType.CompositeSurface;
                case "GeometryInstance":
                    return GeometryType.GeometryInstance;
                case "MultiLineString":
                    return GeometryType.MultiLineString;
                case "MultiPoint":
                    return GeometryType.MultiPoint;
                case "MultiSolid":
                    return GeometryType.MultiSolid;
                case "MultiSurface":
                    return GeometryType.MultiSurface;
                case "Solid":
                    return GeometryType.Solid;
            }
            throw new Exception("Cannot unmarshal type GeometryType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GeometryType)untypedValue;
            switch (value)
            {
                case GeometryType.CompositeSolid:
                    serializer.Serialize(writer, "CompositeSolid");
                    return;
                case GeometryType.CompositeSurface:
                    serializer.Serialize(writer, "CompositeSurface");
                    return;
                case GeometryType.GeometryInstance:
                    serializer.Serialize(writer, "GeometryInstance");
                    return;
                case GeometryType.MultiLineString:
                    serializer.Serialize(writer, "MultiLineString");
                    return;
                case GeometryType.MultiPoint:
                    serializer.Serialize(writer, "MultiPoint");
                    return;
                case GeometryType.MultiSolid:
                    serializer.Serialize(writer, "MultiSolid");
                    return;
                case GeometryType.MultiSurface:
                    serializer.Serialize(writer, "MultiSurface");
                    return;
                case GeometryType.Solid:
                    serializer.Serialize(writer, "Solid");
                    return;
            }
            throw new Exception("Cannot marshal type GeometryType");
        }

        public static readonly GeometryTypeConverter Singleton = new GeometryTypeConverter();
    }

    internal class TextureTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TextureTypeEnum) || t == typeof(TextureTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "specific":
                    return TextureTypeEnum.Specific;
                case "typical":
                    return TextureTypeEnum.Typical;
                case "unknown":
                    return TextureTypeEnum.Unknown;
            }
            throw new Exception("Cannot unmarshal type TextureTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TextureTypeEnum)untypedValue;
            switch (value)
            {
                case TextureTypeEnum.Specific:
                    serializer.Serialize(writer, "specific");
                    return;
                case TextureTypeEnum.Typical:
                    serializer.Serialize(writer, "typical");
                    return;
                case TextureTypeEnum.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type TextureTypeEnum");
        }

        public static readonly TextureTypeEnumConverter Singleton = new TextureTypeEnumConverter();
    }

    internal class TextureTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TextureType) || t == typeof(TextureType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "JPG":
                    return TextureType.Jpg;
                case "PNG":
                    return TextureType.Png;
            }
            throw new Exception("Cannot unmarshal type TextureType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TextureType)untypedValue;
            switch (value)
            {
                case TextureType.Jpg:
                    serializer.Serialize(writer, "JPG");
                    return;
                case TextureType.Png:
                    serializer.Serialize(writer, "PNG");
                    return;
            }
            throw new Exception("Cannot marshal type TextureType");
        }

        public static readonly TextureTypeConverter Singleton = new TextureTypeConverter();
    }

    internal class WrapModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(WrapMode) || t == typeof(WrapMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "border":
                    return WrapMode.Border;
                case "clamp":
                    return WrapMode.Clamp;
                case "mirror":
                    return WrapMode.Mirror;
                case "none":
                    return WrapMode.None;
                case "wrap":
                    return WrapMode.Wrap;
            }
            throw new Exception("Cannot unmarshal type WrapMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (WrapMode)untypedValue;
            switch (value)
            {
                case WrapMode.Border:
                    serializer.Serialize(writer, "border");
                    return;
                case WrapMode.Clamp:
                    serializer.Serialize(writer, "clamp");
                    return;
                case WrapMode.Mirror:
                    serializer.Serialize(writer, "mirror");
                    return;
                case WrapMode.None:
                    serializer.Serialize(writer, "none");
                    return;
                case WrapMode.Wrap:
                    serializer.Serialize(writer, "wrap");
                    return;
            }
            throw new Exception("Cannot marshal type WrapMode");
        }

        public static readonly WrapModeConverter Singleton = new WrapModeConverter();
    }

    internal class TemplateTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TemplateType) || t == typeof(TemplateType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CompositeSolid":
                    return TemplateType.CompositeSolid;
                case "CompositeSurface":
                    return TemplateType.CompositeSurface;
                case "MultiLineString":
                    return TemplateType.MultiLineString;
                case "MultiPoint":
                    return TemplateType.MultiPoint;
                case "MultiSolid":
                    return TemplateType.MultiSolid;
                case "MultiSurface":
                    return TemplateType.MultiSurface;
                case "Solid":
                    return TemplateType.Solid;
            }
            throw new Exception("Cannot unmarshal type TemplateType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TemplateType)untypedValue;
            switch (value)
            {
                case TemplateType.CompositeSolid:
                    serializer.Serialize(writer, "CompositeSolid");
                    return;
                case TemplateType.CompositeSurface:
                    serializer.Serialize(writer, "CompositeSurface");
                    return;
                case TemplateType.MultiLineString:
                    serializer.Serialize(writer, "MultiLineString");
                    return;
                case TemplateType.MultiPoint:
                    serializer.Serialize(writer, "MultiPoint");
                    return;
                case TemplateType.MultiSolid:
                    serializer.Serialize(writer, "MultiSolid");
                    return;
                case TemplateType.MultiSurface:
                    serializer.Serialize(writer, "MultiSurface");
                    return;
                case TemplateType.Solid:
                    serializer.Serialize(writer, "Solid");
                    return;
            }
            throw new Exception("Cannot marshal type TemplateType");
        }

        public static readonly TemplateTypeConverter Singleton = new TemplateTypeConverter();
    }

    internal class LegalConstraintsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegalConstraints) || t == typeof(LegalConstraints?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "confidential":
                    return LegalConstraints.Confidential;
                case "copyright":
                    return LegalConstraints.Copyright;
                case "in-confidence":
                    return LegalConstraints.InConfidence;
                case "intellectualPropertyRights":
                    return LegalConstraints.IntellectualPropertyRights;
                case "licence":
                    return LegalConstraints.Licence;
                case "licenseDistributor":
                    return LegalConstraints.LicenseDistributor;
                case "licenseEndUser":
                    return LegalConstraints.LicenseEndUser;
                case "licenseUnrestricted":
                    return LegalConstraints.LicenseUnrestricted;
                case "otherRestrictions":
                    return LegalConstraints.OtherRestrictions;
                case "patent":
                    return LegalConstraints.Patent;
                case "patentPending":
                    return LegalConstraints.PatentPending;
                case "private":
                    return LegalConstraints.Private;
                case "restricted":
                    return LegalConstraints.Restricted;
                case "sensitiveButUnclassified":
                    return LegalConstraints.SensitiveButUnclassified;
                case "statutory":
                    return LegalConstraints.Statutory;
                case "trademark":
                    return LegalConstraints.Trademark;
                case "unrestricted":
                    return LegalConstraints.Unrestricted;
            }
            throw new Exception("Cannot unmarshal type LegalConstraints");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LegalConstraints)untypedValue;
            switch (value)
            {
                case LegalConstraints.Confidential:
                    serializer.Serialize(writer, "confidential");
                    return;
                case LegalConstraints.Copyright:
                    serializer.Serialize(writer, "copyright");
                    return;
                case LegalConstraints.InConfidence:
                    serializer.Serialize(writer, "in-confidence");
                    return;
                case LegalConstraints.IntellectualPropertyRights:
                    serializer.Serialize(writer, "intellectualPropertyRights");
                    return;
                case LegalConstraints.Licence:
                    serializer.Serialize(writer, "licence");
                    return;
                case LegalConstraints.LicenseDistributor:
                    serializer.Serialize(writer, "licenseDistributor");
                    return;
                case LegalConstraints.LicenseEndUser:
                    serializer.Serialize(writer, "licenseEndUser");
                    return;
                case LegalConstraints.LicenseUnrestricted:
                    serializer.Serialize(writer, "licenseUnrestricted");
                    return;
                case LegalConstraints.OtherRestrictions:
                    serializer.Serialize(writer, "otherRestrictions");
                    return;
                case LegalConstraints.Patent:
                    serializer.Serialize(writer, "patent");
                    return;
                case LegalConstraints.PatentPending:
                    serializer.Serialize(writer, "patentPending");
                    return;
                case LegalConstraints.Private:
                    serializer.Serialize(writer, "private");
                    return;
                case LegalConstraints.Restricted:
                    serializer.Serialize(writer, "restricted");
                    return;
                case LegalConstraints.SensitiveButUnclassified:
                    serializer.Serialize(writer, "sensitiveButUnclassified");
                    return;
                case LegalConstraints.Statutory:
                    serializer.Serialize(writer, "statutory");
                    return;
                case LegalConstraints.Trademark:
                    serializer.Serialize(writer, "trademark");
                    return;
                case LegalConstraints.Unrestricted:
                    serializer.Serialize(writer, "unrestricted");
                    return;
            }
            throw new Exception("Cannot marshal type LegalConstraints");
        }

        public static readonly LegalConstraintsConverter Singleton = new LegalConstraintsConverter();
    }

    internal class SecurityConstraintsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SecurityConstraints) || t == typeof(SecurityConstraints?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "confidential":
                    return SecurityConstraints.Confidential;
                case "forOfficialUseOnly":
                    return SecurityConstraints.ForOfficialUseOnly;
                case "limitedDistribution":
                    return SecurityConstraints.LimitedDistribution;
                case "protected":
                    return SecurityConstraints.Protected;
                case "restricted":
                    return SecurityConstraints.Restricted;
                case "secret":
                    return SecurityConstraints.Secret;
                case "sensitiveButUnclassified":
                    return SecurityConstraints.SensitiveButUnclassified;
                case "topSecret":
                    return SecurityConstraints.TopSecret;
                case "unclassified":
                    return SecurityConstraints.Unclassified;
            }
            throw new Exception("Cannot unmarshal type SecurityConstraints");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SecurityConstraints)untypedValue;
            switch (value)
            {
                case SecurityConstraints.Confidential:
                    serializer.Serialize(writer, "confidential");
                    return;
                case SecurityConstraints.ForOfficialUseOnly:
                    serializer.Serialize(writer, "forOfficialUseOnly");
                    return;
                case SecurityConstraints.LimitedDistribution:
                    serializer.Serialize(writer, "limitedDistribution");
                    return;
                case SecurityConstraints.Protected:
                    serializer.Serialize(writer, "protected");
                    return;
                case SecurityConstraints.Restricted:
                    serializer.Serialize(writer, "restricted");
                    return;
                case SecurityConstraints.Secret:
                    serializer.Serialize(writer, "secret");
                    return;
                case SecurityConstraints.SensitiveButUnclassified:
                    serializer.Serialize(writer, "sensitiveButUnclassified");
                    return;
                case SecurityConstraints.TopSecret:
                    serializer.Serialize(writer, "topSecret");
                    return;
                case SecurityConstraints.Unclassified:
                    serializer.Serialize(writer, "unclassified");
                    return;
            }
            throw new Exception("Cannot marshal type SecurityConstraints");
        }

        public static readonly SecurityConstraintsConverter Singleton = new SecurityConstraintsConverter();
    }

    internal class ContactTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ContactType) || t == typeof(ContactType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "individual":
                    return ContactType.Individual;
                case "organization":
                    return ContactType.Organization;
            }
            throw new Exception("Cannot unmarshal type ContactType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ContactType)untypedValue;
            switch (value)
            {
                case ContactType.Individual:
                    serializer.Serialize(writer, "individual");
                    return;
                case ContactType.Organization:
                    serializer.Serialize(writer, "organization");
                    return;
            }
            throw new Exception("Cannot marshal type ContactType");
        }

        public static readonly ContactTypeConverter Singleton = new ContactTypeConverter();
    }

    internal class RoleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Role) || t == typeof(Role?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "author":
                    return Role.Author;
                case "co-author":
                    return Role.CoAuthor;
                case "collaborator":
                    return Role.Collaborator;
                case "contributor":
                    return Role.Contributor;
                case "custodian":
                    return Role.Custodian;
                case "distributor":
                    return Role.Distributor;
                case "editor":
                    return Role.Editor;
                case "funder":
                    return Role.Funder;
                case "mediator":
                    return Role.Mediator;
                case "originator":
                    return Role.Originator;
                case "owner":
                    return Role.Owner;
                case "pointOfContact":
                    return Role.PointOfContact;
                case "principalInvestigator":
                    return Role.PrincipalInvestigator;
                case "processor":
                    return Role.Processor;
                case "publisher":
                    return Role.Publisher;
                case "resourceProvider":
                    return Role.ResourceProvider;
                case "rightsHolder":
                    return Role.RightsHolder;
                case "sponsor":
                    return Role.Sponsor;
                case "stakeholder":
                    return Role.Stakeholder;
                case "user":
                    return Role.User;
            }
            throw new Exception("Cannot unmarshal type Role");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Role)untypedValue;
            switch (value)
            {
                case Role.Author:
                    serializer.Serialize(writer, "author");
                    return;
                case Role.CoAuthor:
                    serializer.Serialize(writer, "co-author");
                    return;
                case Role.Collaborator:
                    serializer.Serialize(writer, "collaborator");
                    return;
                case Role.Contributor:
                    serializer.Serialize(writer, "contributor");
                    return;
                case Role.Custodian:
                    serializer.Serialize(writer, "custodian");
                    return;
                case Role.Distributor:
                    serializer.Serialize(writer, "distributor");
                    return;
                case Role.Editor:
                    serializer.Serialize(writer, "editor");
                    return;
                case Role.Funder:
                    serializer.Serialize(writer, "funder");
                    return;
                case Role.Mediator:
                    serializer.Serialize(writer, "mediator");
                    return;
                case Role.Originator:
                    serializer.Serialize(writer, "originator");
                    return;
                case Role.Owner:
                    serializer.Serialize(writer, "owner");
                    return;
                case Role.PointOfContact:
                    serializer.Serialize(writer, "pointOfContact");
                    return;
                case Role.PrincipalInvestigator:
                    serializer.Serialize(writer, "principalInvestigator");
                    return;
                case Role.Processor:
                    serializer.Serialize(writer, "processor");
                    return;
                case Role.Publisher:
                    serializer.Serialize(writer, "publisher");
                    return;
                case Role.ResourceProvider:
                    serializer.Serialize(writer, "resourceProvider");
                    return;
                case Role.RightsHolder:
                    serializer.Serialize(writer, "rightsHolder");
                    return;
                case Role.Sponsor:
                    serializer.Serialize(writer, "sponsor");
                    return;
                case Role.Stakeholder:
                    serializer.Serialize(writer, "stakeholder");
                    return;
                case Role.User:
                    serializer.Serialize(writer, "user");
                    return;
            }
            throw new Exception("Cannot marshal type Role");
        }

        public static readonly RoleConverter Singleton = new RoleConverter();
    }

    internal class DatasetTopicCategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DatasetTopicCategory) || t == typeof(DatasetTopicCategory?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "atmosphere":
                    return DatasetTopicCategory.Atmosphere;
                case "bioata":
                    return DatasetTopicCategory.Bioata;
                case "boundaries":
                    return DatasetTopicCategory.Boundaries;
                case "climatology":
                    return DatasetTopicCategory.Climatology;
                case "disaster":
                    return DatasetTopicCategory.Disaster;
                case "economy":
                    return DatasetTopicCategory.Economy;
                case "elevation":
                    return DatasetTopicCategory.Elevation;
                case "environment":
                    return DatasetTopicCategory.Environment;
                case "extraTerrestrial":
                    return DatasetTopicCategory.ExtraTerrestrial;
                case "farming":
                    return DatasetTopicCategory.Farming;
                case "geoscientificInformation":
                    return DatasetTopicCategory.GeoscientificInformation;
                case "health":
                    return DatasetTopicCategory.Health;
                case "imageryBaseMapsEarthCover":
                    return DatasetTopicCategory.ImageryBaseMapsEarthCover;
                case "inlandWaters":
                    return DatasetTopicCategory.InlandWaters;
                case "intelligenceMilitary":
                    return DatasetTopicCategory.IntelligenceMilitary;
                case "location":
                    return DatasetTopicCategory.Location;
                case "meteorology":
                    return DatasetTopicCategory.Meteorology;
                case "oceans":
                    return DatasetTopicCategory.Oceans;
                case "planningCadastre":
                    return DatasetTopicCategory.PlanningCadastre;
                case "society":
                    return DatasetTopicCategory.Society;
                case "structure":
                    return DatasetTopicCategory.Structure;
                case "transportation":
                    return DatasetTopicCategory.Transportation;
                case "utilitiesCommunication":
                    return DatasetTopicCategory.UtilitiesCommunication;
            }
            throw new Exception("Cannot unmarshal type DatasetTopicCategory");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DatasetTopicCategory)untypedValue;
            switch (value)
            {
                case DatasetTopicCategory.Atmosphere:
                    serializer.Serialize(writer, "atmosphere");
                    return;
                case DatasetTopicCategory.Bioata:
                    serializer.Serialize(writer, "bioata");
                    return;
                case DatasetTopicCategory.Boundaries:
                    serializer.Serialize(writer, "boundaries");
                    return;
                case DatasetTopicCategory.Climatology:
                    serializer.Serialize(writer, "climatology");
                    return;
                case DatasetTopicCategory.Disaster:
                    serializer.Serialize(writer, "disaster");
                    return;
                case DatasetTopicCategory.Economy:
                    serializer.Serialize(writer, "economy");
                    return;
                case DatasetTopicCategory.Elevation:
                    serializer.Serialize(writer, "elevation");
                    return;
                case DatasetTopicCategory.Environment:
                    serializer.Serialize(writer, "environment");
                    return;
                case DatasetTopicCategory.ExtraTerrestrial:
                    serializer.Serialize(writer, "extraTerrestrial");
                    return;
                case DatasetTopicCategory.Farming:
                    serializer.Serialize(writer, "farming");
                    return;
                case DatasetTopicCategory.GeoscientificInformation:
                    serializer.Serialize(writer, "geoscientificInformation");
                    return;
                case DatasetTopicCategory.Health:
                    serializer.Serialize(writer, "health");
                    return;
                case DatasetTopicCategory.ImageryBaseMapsEarthCover:
                    serializer.Serialize(writer, "imageryBaseMapsEarthCover");
                    return;
                case DatasetTopicCategory.InlandWaters:
                    serializer.Serialize(writer, "inlandWaters");
                    return;
                case DatasetTopicCategory.IntelligenceMilitary:
                    serializer.Serialize(writer, "intelligenceMilitary");
                    return;
                case DatasetTopicCategory.Location:
                    serializer.Serialize(writer, "location");
                    return;
                case DatasetTopicCategory.Meteorology:
                    serializer.Serialize(writer, "meteorology");
                    return;
                case DatasetTopicCategory.Oceans:
                    serializer.Serialize(writer, "oceans");
                    return;
                case DatasetTopicCategory.PlanningCadastre:
                    serializer.Serialize(writer, "planningCadastre");
                    return;
                case DatasetTopicCategory.Society:
                    serializer.Serialize(writer, "society");
                    return;
                case DatasetTopicCategory.Structure:
                    serializer.Serialize(writer, "structure");
                    return;
                case DatasetTopicCategory.Transportation:
                    serializer.Serialize(writer, "transportation");
                    return;
                case DatasetTopicCategory.UtilitiesCommunication:
                    serializer.Serialize(writer, "utilitiesCommunication");
                    return;
            }
            throw new Exception("Cannot marshal type DatasetTopicCategory");
        }

        public static readonly DatasetTopicCategoryConverter Singleton = new DatasetTopicCategoryConverter();
    }

    internal class ThematicModelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ThematicModel) || t == typeof(ThematicModel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Bridge":
                    return ThematicModel.Bridge;
                case "Building":
                    return ThematicModel.Building;
                case "CityFurniture":
                    return ThematicModel.CityFurniture;
                case "CityObjectGroup":
                    return ThematicModel.CityObjectGroup;
                case "GenericCityObject":
                    return ThematicModel.GenericCityObject;
                case "LandUse":
                    return ThematicModel.LandUse;
                case "PlantCover":
                    return ThematicModel.PlantCover;
                case "Railway":
                    return ThematicModel.Railway;
                case "Road":
                    return ThematicModel.Road;
                case "SolitaryVegetationObject":
                    return ThematicModel.SolitaryVegetationObject;
                case "TINRelief":
                    return ThematicModel.TinRelief;
                case "TransportSquare":
                    return ThematicModel.TransportSquare;
                case "Tunnel":
                    return ThematicModel.Tunnel;
                case "WaterBody":
                    return ThematicModel.WaterBody;
            }
            throw new Exception("Cannot unmarshal type ThematicModel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ThematicModel)untypedValue;
            switch (value)
            {
                case ThematicModel.Bridge:
                    serializer.Serialize(writer, "Bridge");
                    return;
                case ThematicModel.Building:
                    serializer.Serialize(writer, "Building");
                    return;
                case ThematicModel.CityFurniture:
                    serializer.Serialize(writer, "CityFurniture");
                    return;
                case ThematicModel.CityObjectGroup:
                    serializer.Serialize(writer, "CityObjectGroup");
                    return;
                case ThematicModel.GenericCityObject:
                    serializer.Serialize(writer, "GenericCityObject");
                    return;
                case ThematicModel.LandUse:
                    serializer.Serialize(writer, "LandUse");
                    return;
                case ThematicModel.PlantCover:
                    serializer.Serialize(writer, "PlantCover");
                    return;
                case ThematicModel.Railway:
                    serializer.Serialize(writer, "Railway");
                    return;
                case ThematicModel.Road:
                    serializer.Serialize(writer, "Road");
                    return;
                case ThematicModel.SolitaryVegetationObject:
                    serializer.Serialize(writer, "SolitaryVegetationObject");
                    return;
                case ThematicModel.TinRelief:
                    serializer.Serialize(writer, "TINRelief");
                    return;
                case ThematicModel.TransportSquare:
                    serializer.Serialize(writer, "TransportSquare");
                    return;
                case ThematicModel.Tunnel:
                    serializer.Serialize(writer, "Tunnel");
                    return;
                case ThematicModel.WaterBody:
                    serializer.Serialize(writer, "WaterBody");
                    return;
            }
            throw new Exception("Cannot marshal type ThematicModel");
        }

        public static readonly ThematicModelConverter Singleton = new ThematicModelConverter();
    }

    internal class MaterialsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Materials) || t == typeof(Materials?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "absent":
                    return Materials.Absent;
                case "present":
                    return Materials.Present;
            }
            throw new Exception("Cannot unmarshal type Materials");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Materials)untypedValue;
            switch (value)
            {
                case Materials.Absent:
                    serializer.Serialize(writer, "absent");
                    return;
                case Materials.Present:
                    serializer.Serialize(writer, "present");
                    return;
            }
            throw new Exception("Cannot marshal type Materials");
        }

        public static readonly MaterialsConverter Singleton = new MaterialsConverter();
    }

    internal class SpatialRepresentationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SpatialRepresentationType) || t == typeof(SpatialRepresentationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "TIN":
                    return SpatialRepresentationType.Tin;
                case "grid":
                    return SpatialRepresentationType.Grid;
                case "stereoModel":
                    return SpatialRepresentationType.StereoModel;
                case "textTable":
                    return SpatialRepresentationType.TextTable;
                case "vector":
                    return SpatialRepresentationType.Vector;
                case "video":
                    return SpatialRepresentationType.Video;
            }
            throw new Exception("Cannot unmarshal type SpatialRepresentationType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SpatialRepresentationType)untypedValue;
            switch (value)
            {
                case SpatialRepresentationType.Tin:
                    serializer.Serialize(writer, "TIN");
                    return;
                case SpatialRepresentationType.Grid:
                    serializer.Serialize(writer, "grid");
                    return;
                case SpatialRepresentationType.StereoModel:
                    serializer.Serialize(writer, "stereoModel");
                    return;
                case SpatialRepresentationType.TextTable:
                    serializer.Serialize(writer, "textTable");
                    return;
                case SpatialRepresentationType.Vector:
                    serializer.Serialize(writer, "vector");
                    return;
                case SpatialRepresentationType.Video:
                    serializer.Serialize(writer, "video");
                    return;
            }
            throw new Exception("Cannot marshal type SpatialRepresentationType");
        }

        public static readonly SpatialRepresentationTypeConverter Singleton = new SpatialRepresentationTypeConverter();
    }

    internal class CoordinateTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CoordinateType) || t == typeof(CoordinateType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "CityJSON")
            {
                return CoordinateType.CityJson;
            }
            throw new Exception("Cannot unmarshal type CoordinateType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CoordinateType)untypedValue;
            if (value == CoordinateType.CityJson)
            {
                serializer.Serialize(writer, "CityJSON");
                return;
            }
            throw new Exception("Cannot marshal type CoordinateType");
        }

        public static readonly CoordinateTypeConverter Singleton = new CoordinateTypeConverter();
    }
}