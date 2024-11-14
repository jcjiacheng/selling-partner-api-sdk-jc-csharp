/*
 * Selling Partner APIs for Fulfillment Outbound
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
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
import com.amazon.SellingPartnerAPI.models.Address;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * Return authorization information for items accepted for return.
 */
@Schema(description = "Return authorization information for items accepted for return.")


public class ReturnAuthorization {
  @SerializedName("returnAuthorizationId")
  private String returnAuthorizationId = null;

  @SerializedName("fulfillmentCenterId")
  private String fulfillmentCenterId = null;

  @SerializedName("returnToAddress")
  private Address returnToAddress = null;

  @SerializedName("amazonRmaId")
  private String amazonRmaId = null;

  @SerializedName("rmaPageURL")
  private String rmaPageURL = null;

  public ReturnAuthorization returnAuthorizationId(String returnAuthorizationId) {
    this.returnAuthorizationId = returnAuthorizationId;
    return this;
  }

   /**
   * An identifier for the return authorization. This identifier associates return items with the return authorization used to return them.
   * @return returnAuthorizationId
  **/
  @Schema(required = true, description = "An identifier for the return authorization. This identifier associates return items with the return authorization used to return them.")
  public String getReturnAuthorizationId() {
    return returnAuthorizationId;
  }

  public void setReturnAuthorizationId(String returnAuthorizationId) {
    this.returnAuthorizationId = returnAuthorizationId;
  }

  public ReturnAuthorization fulfillmentCenterId(String fulfillmentCenterId) {
    this.fulfillmentCenterId = fulfillmentCenterId;
    return this;
  }

   /**
   * An identifier for the Amazon fulfillment center that the return items should be sent to.
   * @return fulfillmentCenterId
  **/
  @Schema(required = true, description = "An identifier for the Amazon fulfillment center that the return items should be sent to.")
  public String getFulfillmentCenterId() {
    return fulfillmentCenterId;
  }

  public void setFulfillmentCenterId(String fulfillmentCenterId) {
    this.fulfillmentCenterId = fulfillmentCenterId;
  }

  public ReturnAuthorization returnToAddress(Address returnToAddress) {
    this.returnToAddress = returnToAddress;
    return this;
  }

   /**
   * Get returnToAddress
   * @return returnToAddress
  **/
  @Schema(required = true, description = "")
  public Address getReturnToAddress() {
    return returnToAddress;
  }

  public void setReturnToAddress(Address returnToAddress) {
    this.returnToAddress = returnToAddress;
  }

  public ReturnAuthorization amazonRmaId(String amazonRmaId) {
    this.amazonRmaId = amazonRmaId;
    return this;
  }

   /**
   * The return merchandise authorization (RMA) that Amazon needs to process the return.
   * @return amazonRmaId
  **/
  @Schema(required = true, description = "The return merchandise authorization (RMA) that Amazon needs to process the return.")
  public String getAmazonRmaId() {
    return amazonRmaId;
  }

  public void setAmazonRmaId(String amazonRmaId) {
    this.amazonRmaId = amazonRmaId;
  }

  public ReturnAuthorization rmaPageURL(String rmaPageURL) {
    this.rmaPageURL = rmaPageURL;
    return this;
  }

   /**
   * A URL for a web page that contains the return authorization barcode and the mailing label. This does not include pre-paid shipping.
   * @return rmaPageURL
  **/
  @Schema(required = true, description = "A URL for a web page that contains the return authorization barcode and the mailing label. This does not include pre-paid shipping.")
  public String getRmaPageURL() {
    return rmaPageURL;
  }

  public void setRmaPageURL(String rmaPageURL) {
    this.rmaPageURL = rmaPageURL;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ReturnAuthorization returnAuthorization = (ReturnAuthorization) o;
    return Objects.equals(this.returnAuthorizationId, returnAuthorization.returnAuthorizationId) &&
        Objects.equals(this.fulfillmentCenterId, returnAuthorization.fulfillmentCenterId) &&
        Objects.equals(this.returnToAddress, returnAuthorization.returnToAddress) &&
        Objects.equals(this.amazonRmaId, returnAuthorization.amazonRmaId) &&
        Objects.equals(this.rmaPageURL, returnAuthorization.rmaPageURL);
  }

  @Override
  public int hashCode() {
    return Objects.hash(returnAuthorizationId, fulfillmentCenterId, returnToAddress, amazonRmaId, rmaPageURL);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ReturnAuthorization {\n");
    
    sb.append("    returnAuthorizationId: ").append(toIndentedString(returnAuthorizationId)).append("\n");
    sb.append("    fulfillmentCenterId: ").append(toIndentedString(fulfillmentCenterId)).append("\n");
    sb.append("    returnToAddress: ").append(toIndentedString(returnToAddress)).append("\n");
    sb.append("    amazonRmaId: ").append(toIndentedString(amazonRmaId)).append("\n");
    sb.append("    rmaPageURL: ").append(toIndentedString(rmaPageURL)).append("\n");
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
