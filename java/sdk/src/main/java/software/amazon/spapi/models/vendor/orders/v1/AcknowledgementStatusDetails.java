/*
 * Selling Partner API for Retail Procurement Orders
 * The Selling Partner API for Retail Procurement Orders provides programmatic access to vendor orders data.
 *
 * OpenAPI spec version: v1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package software.amazon.spapi.models.vendor.orders.v1;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.OffsetDateTime;
import software.amazon.spapi.models.vendor.orders.v1.ItemQuantity;
/**
 * Details of item quantity ordered
 */
@Schema(description = "Details of item quantity ordered")


public class AcknowledgementStatusDetails {
  @SerializedName("acknowledgementDate")
  private OffsetDateTime acknowledgementDate = null;

  @SerializedName("acceptedQuantity")
  private ItemQuantity acceptedQuantity = null;

  @SerializedName("rejectedQuantity")
  private ItemQuantity rejectedQuantity = null;

  public AcknowledgementStatusDetails acknowledgementDate(OffsetDateTime acknowledgementDate) {
    this.acknowledgementDate = acknowledgementDate;
    return this;
  }

   /**
   * The date when the line item was confirmed by vendor. Must be in ISO-8601 date/time format.
   * @return acknowledgementDate
  **/
  @Schema(description = "The date when the line item was confirmed by vendor. Must be in ISO-8601 date/time format.")
  public OffsetDateTime getAcknowledgementDate() {
    return acknowledgementDate;
  }

  public void setAcknowledgementDate(OffsetDateTime acknowledgementDate) {
    this.acknowledgementDate = acknowledgementDate;
  }

  public AcknowledgementStatusDetails acceptedQuantity(ItemQuantity acceptedQuantity) {
    this.acceptedQuantity = acceptedQuantity;
    return this;
  }

   /**
   * Get acceptedQuantity
   * @return acceptedQuantity
  **/
  @Schema(description = "")
  public ItemQuantity getAcceptedQuantity() {
    return acceptedQuantity;
  }

  public void setAcceptedQuantity(ItemQuantity acceptedQuantity) {
    this.acceptedQuantity = acceptedQuantity;
  }

  public AcknowledgementStatusDetails rejectedQuantity(ItemQuantity rejectedQuantity) {
    this.rejectedQuantity = rejectedQuantity;
    return this;
  }

   /**
   * Get rejectedQuantity
   * @return rejectedQuantity
  **/
  @Schema(description = "")
  public ItemQuantity getRejectedQuantity() {
    return rejectedQuantity;
  }

  public void setRejectedQuantity(ItemQuantity rejectedQuantity) {
    this.rejectedQuantity = rejectedQuantity;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AcknowledgementStatusDetails acknowledgementStatusDetails = (AcknowledgementStatusDetails) o;
    return Objects.equals(this.acknowledgementDate, acknowledgementStatusDetails.acknowledgementDate) &&
        Objects.equals(this.acceptedQuantity, acknowledgementStatusDetails.acceptedQuantity) &&
        Objects.equals(this.rejectedQuantity, acknowledgementStatusDetails.rejectedQuantity);
  }

  @Override
  public int hashCode() {
    return Objects.hash(acknowledgementDate, acceptedQuantity, rejectedQuantity);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AcknowledgementStatusDetails {\n");
    
    sb.append("    acknowledgementDate: ").append(toIndentedString(acknowledgementDate)).append("\n");
    sb.append("    acceptedQuantity: ").append(toIndentedString(acceptedQuantity)).append("\n");
    sb.append("    rejectedQuantity: ").append(toIndentedString(rejectedQuantity)).append("\n");
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
