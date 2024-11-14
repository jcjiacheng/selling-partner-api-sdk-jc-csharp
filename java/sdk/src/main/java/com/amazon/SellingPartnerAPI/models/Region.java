/*
 * Fulfillment Inbound v2024-03-20
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package com.amazon.SellingPartnerAPI.models;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * Representation of a location used within the inbounding experience.
 */
@Schema(description = "Representation of a location used within the inbounding experience.")


public class Region {
  @SerializedName("countryCode")
  private String countryCode = null;

  @SerializedName("state")
  private String state = null;

  @SerializedName("warehouseId")
  private String warehouseId = null;

  public Region countryCode(String countryCode) {
    this.countryCode = countryCode;
    return this;
  }

   /**
   * ISO 3166 standard alpha-2 country code.
   * @return countryCode
  **/
  @Schema(description = "ISO 3166 standard alpha-2 country code.")
  public String getCountryCode() {
    return countryCode;
  }

  public void setCountryCode(String countryCode) {
    this.countryCode = countryCode;
  }

  public Region state(String state) {
    this.state = state;
    return this;
  }

   /**
   * State.
   * @return state
  **/
  @Schema(description = "State.")
  public String getState() {
    return state;
  }

  public void setState(String state) {
    this.state = state;
  }

  public Region warehouseId(String warehouseId) {
    this.warehouseId = warehouseId;
    return this;
  }

   /**
   * An identifier for a warehouse, such as a FC, IXD, upstream storage.
   * @return warehouseId
  **/
  @Schema(description = "An identifier for a warehouse, such as a FC, IXD, upstream storage.")
  public String getWarehouseId() {
    return warehouseId;
  }

  public void setWarehouseId(String warehouseId) {
    this.warehouseId = warehouseId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Region region = (Region) o;
    return Objects.equals(this.countryCode, region.countryCode) &&
        Objects.equals(this.state, region.state) &&
        Objects.equals(this.warehouseId, region.warehouseId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(countryCode, state, warehouseId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Region {\n");
    
    sb.append("    countryCode: ").append(toIndentedString(countryCode)).append("\n");
    sb.append("    state: ").append(toIndentedString(state)).append("\n");
    sb.append("    warehouseId: ").append(toIndentedString(warehouseId)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
