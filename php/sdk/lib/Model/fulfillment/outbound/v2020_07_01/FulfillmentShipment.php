<?php
/**
 * FulfillmentShipment
 *
 * PHP version 8.3
 *
 * @category Class
 * @package  SpApi
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * The version of the OpenAPI document: 2020-07-01
 * Generated by: https://openapi-generator.tech
 * Generator version: 7.9.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace SpApi\Model\fulfillment\outbound\v2020_07_01;

use
ArrayAccess;
use SpApi\ObjectSerializer;
use SpApi\Model\ModelInterface;

/**
 * FulfillmentShipment Class Doc Comment
 *
 * @category Class
 * @description Delivery and item information for a shipment in a fulfillment order.
 * @package  SpApi
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<string, mixed>
 */
class FulfillmentShipment implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static string $openAPIModelName = 'FulfillmentShipment';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static array $openAPITypes = [
             'amazon_shipment_id' => 'string',
             'fulfillment_center_id' => 'string',
             'fulfillment_shipment_status' => 'string',
             'shipping_date' => '\DateTime',
             'estimated_arrival_date' => '\DateTime',
             'shipping_notes' => 'string[]',
             'fulfillment_shipment_item' => '\SpApi\Model\fulfillment\outbound\v2020_07_01\FulfillmentShipmentItem[]',
             'fulfillment_shipment_package' => '\SpApi\Model\fulfillment\outbound\v2020_07_01\FulfillmentShipmentPackage[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static array $openAPIFormats = [
            'amazon_shipment_id' => null,
            'fulfillment_center_id' => null,
            'fulfillment_shipment_status' => null,
            'shipping_date' => 'date-time',
            'estimated_arrival_date' => 'date-time',
            'shipping_notes' => null,
            'fulfillment_shipment_item' => null,
            'fulfillment_shipment_package' => null    ];

    /**
      * Array of nullable properties. Used for (de)serialization
      *
      * @var boolean[]
      */
    protected static array $openAPINullables = [
        'amazon_shipment_id' => false,
        'fulfillment_center_id' => false,
        'fulfillment_shipment_status' => false,
        'shipping_date' => true,
        'estimated_arrival_date' => true,
        'shipping_notes' => true,
        'fulfillment_shipment_item' => false,
        'fulfillment_shipment_package' => true
    ];

    /**
      * If a nullable field gets set to null, insert it here
      *
      * @var boolean[]
      */
    protected array $openAPINullablesSetToNull = [];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes(): array
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats(): array
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of nullable properties
     *
     * @return array
     */
    protected static function openAPINullables(): array
    {
        return self::$openAPINullables;
    }

    /**
     * Array of nullable field names deliberately set to null
     *
     * @return boolean[]
     */
    private function getOpenAPINullablesSetToNull(): array
    {
        return $this->openAPINullablesSetToNull;
    }

    /**
     * Setter - Array of nullable field names deliberately set to null
     *
     * @param boolean[] $openAPINullablesSetToNull
     */
    private function setOpenAPINullablesSetToNull(array $openAPINullablesSetToNull): void
    {
        $this->openAPINullablesSetToNull = $openAPINullablesSetToNull;
    }

    /**
     * Checks if a property is nullable
     *
     * @param string $property
     * @return bool
     */
    public static function isNullable(string $property): bool
    {
        return self::openAPINullables()[$property] ?? false;
    }

    /**
     * Checks if a nullable property is set to null.
     *
     * @param string $property
     * @return bool
     */
    public function isNullableSetToNull(string $property): bool
    {
        return in_array($property, $this->getOpenAPINullablesSetToNull(), true);
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static array $attributeMap = [
        'amazon_shipment_id' => 'amazonShipmentId',
                'fulfillment_center_id' => 'fulfillmentCenterId',
                'fulfillment_shipment_status' => 'fulfillmentShipmentStatus',
                'shipping_date' => 'shippingDate',
                'estimated_arrival_date' => 'estimatedArrivalDate',
                'shipping_notes' => 'shippingNotes',
                'fulfillment_shipment_item' => 'fulfillmentShipmentItem',
                'fulfillment_shipment_package' => 'fulfillmentShipmentPackage'
        
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static array $setters = [
        'amazon_shipment_id' => 'setAmazonShipmentId',
        'fulfillment_center_id' => 'setFulfillmentCenterId',
        'fulfillment_shipment_status' => 'setFulfillmentShipmentStatus',
        'shipping_date' => 'setShippingDate',
        'estimated_arrival_date' => 'setEstimatedArrivalDate',
        'shipping_notes' => 'setShippingNotes',
        'fulfillment_shipment_item' => 'setFulfillmentShipmentItem',
        'fulfillment_shipment_package' => 'setFulfillmentShipmentPackage'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static array $getters = [
        'amazon_shipment_id' => 'getAmazonShipmentId',
        'fulfillment_center_id' => 'getFulfillmentCenterId',
        'fulfillment_shipment_status' => 'getFulfillmentShipmentStatus',
        'shipping_date' => 'getShippingDate',
        'estimated_arrival_date' => 'getEstimatedArrivalDate',
        'shipping_notes' => 'getShippingNotes',
        'fulfillment_shipment_item' => 'getFulfillmentShipmentItem',
        'fulfillment_shipment_package' => 'getFulfillmentShipmentPackage'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap(): array
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters(): array
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters(): array
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName(): string
    {
        return self::$openAPIModelName;
    }

    public const FULFILLMENT_SHIPMENT_STATUS_PENDING = 'PENDING';
    public const FULFILLMENT_SHIPMENT_STATUS_SHIPPED = 'SHIPPED';
    public const FULFILLMENT_SHIPMENT_STATUS_CANCELLED_BY_FULFILLER = 'CANCELLED_BY_FULFILLER';
    public const FULFILLMENT_SHIPMENT_STATUS_CANCELLED_BY_SELLER = 'CANCELLED_BY_SELLER';

    /**
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getFulfillmentShipmentStatusAllowableValues(): array
    {
        return [
            self::FULFILLMENT_SHIPMENT_STATUS_PENDING,
            self::FULFILLMENT_SHIPMENT_STATUS_SHIPPED,
            self::FULFILLMENT_SHIPMENT_STATUS_CANCELLED_BY_FULFILLER,
            self::FULFILLMENT_SHIPMENT_STATUS_CANCELLED_BY_SELLER,
        ];
    }

    /**
     * Associative array for storing property values
     *
     * @var array
     */
    protected array $container = [];

    /**
     * Constructor
     *
     * @param array|null $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(?array $data = null)
    {
        $this->setIfExists('amazon_shipment_id', $data ?? [], null);
        $this->setIfExists('fulfillment_center_id', $data ?? [], null);
        $this->setIfExists('fulfillment_shipment_status', $data ?? [], null);
        $this->setIfExists('shipping_date', $data ?? [], null);
        $this->setIfExists('estimated_arrival_date', $data ?? [], null);
        $this->setIfExists('shipping_notes', $data ?? [], null);
        $this->setIfExists('fulfillment_shipment_item', $data ?? [], null);
        $this->setIfExists('fulfillment_shipment_package', $data ?? [], null);
    }

    /**
    * Sets $this->container[$variableName] to the given data or to the given default Value; if $variableName
    * is nullable and its value is set to null in the $fields array, then mark it as "set to null" in the
    * $this->openAPINullablesSetToNull array
    *
    * @param string $variableName
    * @param array  $fields
    * @param mixed  $defaultValue
    */
    private function setIfExists(string $variableName, array $fields, $defaultValue): void
    {
        if (self::isNullable($variableName) && array_key_exists($variableName, $fields) && is_null($fields[$variableName])) {
            $this->openAPINullablesSetToNull[] = $variableName;
        }

        $this->container[$variableName] = $fields[$variableName] ?? $defaultValue;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties(): array
    {
        $invalidProperties = [];

        if ($this->container['amazon_shipment_id'] === null) {
            $invalidProperties[] = "'amazon_shipment_id' can't be null";
        }
        if ($this->container['fulfillment_center_id'] === null) {
            $invalidProperties[] = "'fulfillment_center_id' can't be null";
        }
        if ($this->container['fulfillment_shipment_status'] === null) {
            $invalidProperties[] = "'fulfillment_shipment_status' can't be null";
        }
        $allowedValues = $this->getFulfillmentShipmentStatusAllowableValues();
        if (!is_null($this->container['fulfillment_shipment_status']) && !in_array($this->container['fulfillment_shipment_status'], $allowedValues, true)) {
            $invalidProperties[] = sprintf(
                "invalid value '%s' for 'fulfillment_shipment_status', must be one of '%s'",
                $this->container['fulfillment_shipment_status'],
                implode("', '", $allowedValues)
            );
        }

        if ($this->container['fulfillment_shipment_item'] === null) {
            $invalidProperties[] = "'fulfillment_shipment_item' can't be null";
        }
        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid(): bool
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets amazon_shipment_id
     *
     * @return string
     */
    public function getAmazonShipmentId(): string
    {
        return $this->container['amazon_shipment_id'];
    }

    /**
     * Sets amazon_shipment_id
     *
     * @param string $amazon_shipment_id A shipment identifier assigned by Amazon.
     *
     * @return self
     */
    public function setAmazonShipmentId(string $amazon_shipment_id): self
    {
        if (is_null($amazon_shipment_id)) {
            throw new \InvalidArgumentException('non-nullable amazon_shipment_id cannot be null');
        }
        $this->container['amazon_shipment_id'] = $amazon_shipment_id;

        return $this;
    }

    /**
     * Gets fulfillment_center_id
     *
     * @return string
     */
    public function getFulfillmentCenterId(): string
    {
        return $this->container['fulfillment_center_id'];
    }

    /**
     * Sets fulfillment_center_id
     *
     * @param string $fulfillment_center_id An identifier for the fulfillment center that the shipment will be sent from.
     *
     * @return self
     */
    public function setFulfillmentCenterId(string $fulfillment_center_id): self
    {
        if (is_null($fulfillment_center_id)) {
            throw new \InvalidArgumentException('non-nullable fulfillment_center_id cannot be null');
        }
        $this->container['fulfillment_center_id'] = $fulfillment_center_id;

        return $this;
    }

    /**
     * Gets fulfillment_shipment_status
     *
     * @return string
     */
    public function getFulfillmentShipmentStatus(): string
    {
        return $this->container['fulfillment_shipment_status'];
    }

    /**
     * Sets fulfillment_shipment_status
     *
     * @param string $fulfillment_shipment_status The current status of the shipment.
     *
     * @return self
     */
    public function setFulfillmentShipmentStatus(string $fulfillment_shipment_status): self
    {
        if (is_null($fulfillment_shipment_status)) {
            throw new \InvalidArgumentException('non-nullable fulfillment_shipment_status cannot be null');
        }
        $allowedValues = $this->getFulfillmentShipmentStatusAllowableValues();
        if (!in_array($fulfillment_shipment_status, $allowedValues, true)) {
            throw new \InvalidArgumentException(
                sprintf(
                    "Invalid value '%s' for 'fulfillment_shipment_status', must be one of '%s'",
                    $fulfillment_shipment_status,
                    implode("', '", $allowedValues)
                )
            );
        }
        $this->container['fulfillment_shipment_status'] = $fulfillment_shipment_status;

        return $this;
    }

    /**
     * Gets shipping_date
     *
     * @return \DateTime|null
     */
    public function getShippingDate(): ?\DateTime
    {
        return $this->container['shipping_date'];
    }

    /**
     * Sets shipping_date
     *
     * @param \DateTime|null $shipping_date Date timestamp
     *
     * @return self
     */
    public function setShippingDate(?\DateTime $shipping_date): self
    {
        if (is_null($shipping_date)) {
            array_push($this->openAPINullablesSetToNull, 'shipping_date');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('shipping_date', $nullablesSetToNull);
            if ($index !== false) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }
        $this->container['shipping_date'] = $shipping_date;

        return $this;
    }

    /**
     * Gets estimated_arrival_date
     *
     * @return \DateTime|null
     */
    public function getEstimatedArrivalDate(): ?\DateTime
    {
        return $this->container['estimated_arrival_date'];
    }

    /**
     * Sets estimated_arrival_date
     *
     * @param \DateTime|null $estimated_arrival_date Date timestamp
     *
     * @return self
     */
    public function setEstimatedArrivalDate(?\DateTime $estimated_arrival_date): self
    {
        if (is_null($estimated_arrival_date)) {
            array_push($this->openAPINullablesSetToNull, 'estimated_arrival_date');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('estimated_arrival_date', $nullablesSetToNull);
            if ($index !== false) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }
        $this->container['estimated_arrival_date'] = $estimated_arrival_date;

        return $this;
    }

    /**
     * Gets shipping_notes
     *
     * @return array|null
     */
    public function getShippingNotes(): ?array
    {
        return $this->container['shipping_notes'];
    }

    /**
     * Sets shipping_notes
     *
     * @param array|null $shipping_notes Provides additional insight into shipment timeline. Primairly used to communicate that actual delivery dates aren't available.
     *
     * @return self
     */
    public function setShippingNotes(?array $shipping_notes): self
    {
        if (is_null($shipping_notes)) {
            array_push($this->openAPINullablesSetToNull, 'shipping_notes');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('shipping_notes', $nullablesSetToNull);
            if ($index !== false) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }
        $this->container['shipping_notes'] = $shipping_notes;

        return $this;
    }

    /**
     * Gets fulfillment_shipment_item
     *
     * @return array
     */
    public function getFulfillmentShipmentItem(): array
    {
        return $this->container['fulfillment_shipment_item'];
    }

    /**
     * Sets fulfillment_shipment_item
     *
     * @param array $fulfillment_shipment_item An array of fulfillment shipment item information.
     *
     * @return self
     */
    public function setFulfillmentShipmentItem(array $fulfillment_shipment_item): self
    {
        if (is_null($fulfillment_shipment_item)) {
            throw new \InvalidArgumentException('non-nullable fulfillment_shipment_item cannot be null');
        }
        $this->container['fulfillment_shipment_item'] = $fulfillment_shipment_item;

        return $this;
    }

    /**
     * Gets fulfillment_shipment_package
     *
     * @return array|null
     */
    public function getFulfillmentShipmentPackage(): ?array
    {
        return $this->container['fulfillment_shipment_package'];
    }

    /**
     * Sets fulfillment_shipment_package
     *
     * @param array|null $fulfillment_shipment_package An array of fulfillment shipment package information.
     *
     * @return self
     */
    public function setFulfillmentShipmentPackage(?array $fulfillment_shipment_package): self
    {
        if (is_null($fulfillment_shipment_package)) {
            array_push($this->openAPINullablesSetToNull, 'fulfillment_shipment_package');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('fulfillment_shipment_package', $nullablesSetToNull);
            if ($index !== false) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }
        $this->container['fulfillment_shipment_package'] = $fulfillment_shipment_package;

        return $this;
    }


    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset): bool
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed|null
     */
    #[\ReturnTypeWillChange]
    public function offsetGet($offset): mixed
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param int|null $offset Offset
     * @param mixed    $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, mixed $value): void
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset): void
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @link https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return mixed Returns data which can be serialized by json_encode(), which is a value
     * of any type other than a resource.
     */
    #[\ReturnTypeWillChange]
    public function jsonSerialize(): mixed
    {
       return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue(): string
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}


