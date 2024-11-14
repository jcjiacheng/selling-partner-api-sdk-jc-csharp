/*
 * Selling Partner API for Supply Sources
 * Manage configurations and capabilities of seller supply sources.
 *
 * OpenAPI spec version: 2020-07-01
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package com.amazon.SellingPartnerAPI.models;

import java.util.Objects;
import java.util.Arrays;
import com.amazon.SellingPartnerAPI.models.OutboundCapability;
import com.amazon.SellingPartnerAPI.models.ServicesCapability;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * The capabilities of a supply source.
 */
@Schema(description = "The capabilities of a supply source.")


public class SupplySourceCapabilities {
  @SerializedName("outbound")
  private OutboundCapability outbound = null;

  @SerializedName("services")
  private ServicesCapability services = null;

  public SupplySourceCapabilities outbound(OutboundCapability outbound) {
    this.outbound = outbound;
    return this;
  }

   /**
   * Get outbound
   * @return outbound
  **/
  @Schema(description = "")
  public OutboundCapability getOutbound() {
    return outbound;
  }

  public void setOutbound(OutboundCapability outbound) {
    this.outbound = outbound;
  }

  public SupplySourceCapabilities services(ServicesCapability services) {
    this.services = services;
    return this;
  }

   /**
   * Get services
   * @return services
  **/
  @Schema(description = "")
  public ServicesCapability getServices() {
    return services;
  }

  public void setServices(ServicesCapability services) {
    this.services = services;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SupplySourceCapabilities supplySourceCapabilities = (SupplySourceCapabilities) o;
    return Objects.equals(this.outbound, supplySourceCapabilities.outbound) &&
        Objects.equals(this.services, supplySourceCapabilities.services);
  }

  @Override
  public int hashCode() {
    return Objects.hash(outbound, services);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SupplySourceCapabilities {\n");
    
    sb.append("    outbound: ").append(toIndentedString(outbound)).append("\n");
    sb.append("    services: ").append(toIndentedString(services)).append("\n");
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
