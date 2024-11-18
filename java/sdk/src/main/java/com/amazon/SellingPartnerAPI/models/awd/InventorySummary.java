/*
 * The Selling Partner API for Amazon Warehousing and Distribution
 * The Selling Partner API for Amazon Warehousing and Distribution (AWD) provides programmatic access to information about AWD shipments and inventory. 
 *
 * OpenAPI spec version: 2024-05-09
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package com.amazon.SellingPartnerAPI.models.awd;

import java.util.Objects;
import java.util.Arrays;
import com.amazon.SellingPartnerAPI.models.awd.InventoryDetails;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * Summary of inventory per SKU.
 */
@Schema(description = "Summary of inventory per SKU.")


public class InventorySummary {
  @SerializedName("inventoryDetails")
  private InventoryDetails inventoryDetails = null;

  @SerializedName("sku")
  private String sku = null;

  @SerializedName("totalInboundQuantity")
  private Long totalInboundQuantity = null;

  @SerializedName("totalOnhandQuantity")
  private Long totalOnhandQuantity = null;

  public InventorySummary inventoryDetails(InventoryDetails inventoryDetails) {
    this.inventoryDetails = inventoryDetails;
    return this;
  }

   /**
   * Get inventoryDetails
   * @return inventoryDetails
  **/
  @Schema(description = "")
  public InventoryDetails getInventoryDetails() {
    return inventoryDetails;
  }

  public void setInventoryDetails(InventoryDetails inventoryDetails) {
    this.inventoryDetails = inventoryDetails;
  }

  public InventorySummary sku(String sku) {
    this.sku = sku;
    return this;
  }

   /**
   * The seller or merchant SKU.
   * @return sku
  **/
  @Schema(required = true, description = "The seller or merchant SKU.")
  public String getSku() {
    return sku;
  }

  public void setSku(String sku) {
    this.sku = sku;
  }

  public InventorySummary totalInboundQuantity(Long totalInboundQuantity) {
    this.totalInboundQuantity = totalInboundQuantity;
    return this;
  }

   /**
   * Total quantity that is in-transit from the seller and has not yet been received at an AWD Distribution Center
   * @return totalInboundQuantity
  **/
  @Schema(description = "Total quantity that is in-transit from the seller and has not yet been received at an AWD Distribution Center")
  public Long getTotalInboundQuantity() {
    return totalInboundQuantity;
  }

  public void setTotalInboundQuantity(Long totalInboundQuantity) {
    this.totalInboundQuantity = totalInboundQuantity;
  }

  public InventorySummary totalOnhandQuantity(Long totalOnhandQuantity) {
    this.totalOnhandQuantity = totalOnhandQuantity;
    return this;
  }

   /**
   * Total quantity that is present in AWD distribution centers.
   * @return totalOnhandQuantity
  **/
  @Schema(description = "Total quantity that is present in AWD distribution centers.")
  public Long getTotalOnhandQuantity() {
    return totalOnhandQuantity;
  }

  public void setTotalOnhandQuantity(Long totalOnhandQuantity) {
    this.totalOnhandQuantity = totalOnhandQuantity;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InventorySummary inventorySummary = (InventorySummary) o;
    return Objects.equals(this.inventoryDetails, inventorySummary.inventoryDetails) &&
        Objects.equals(this.sku, inventorySummary.sku) &&
        Objects.equals(this.totalInboundQuantity, inventorySummary.totalInboundQuantity) &&
        Objects.equals(this.totalOnhandQuantity, inventorySummary.totalOnhandQuantity);
  }

  @Override
  public int hashCode() {
    return Objects.hash(inventoryDetails, sku, totalInboundQuantity, totalOnhandQuantity);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InventorySummary {\n");
    
    sb.append("    inventoryDetails: ").append(toIndentedString(inventoryDetails)).append("\n");
    sb.append("    sku: ").append(toIndentedString(sku)).append("\n");
    sb.append("    totalInboundQuantity: ").append(toIndentedString(totalInboundQuantity)).append("\n");
    sb.append("    totalOnhandQuantity: ").append(toIndentedString(totalOnhandQuantity)).append("\n");
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
