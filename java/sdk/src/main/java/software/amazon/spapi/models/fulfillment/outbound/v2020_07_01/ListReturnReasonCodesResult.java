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

package software.amazon.spapi.models.fulfillment.outbound.v2020_07_01;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import software.amazon.spapi.models.fulfillment.outbound.v2020_07_01.ReasonCodeDetailsList;
/**
 * The request for the listReturnReasonCodes operation.
 */
@Schema(description = "The request for the listReturnReasonCodes operation.")


public class ListReturnReasonCodesResult {
  @SerializedName("reasonCodeDetails")
  private ReasonCodeDetailsList reasonCodeDetails = null;

  public ListReturnReasonCodesResult reasonCodeDetails(ReasonCodeDetailsList reasonCodeDetails) {
    this.reasonCodeDetails = reasonCodeDetails;
    return this;
  }

   /**
   * Get reasonCodeDetails
   * @return reasonCodeDetails
  **/
  @Schema(description = "")
  public ReasonCodeDetailsList getReasonCodeDetails() {
    return reasonCodeDetails;
  }

  public void setReasonCodeDetails(ReasonCodeDetailsList reasonCodeDetails) {
    this.reasonCodeDetails = reasonCodeDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ListReturnReasonCodesResult listReturnReasonCodesResult = (ListReturnReasonCodesResult) o;
    return Objects.equals(this.reasonCodeDetails, listReturnReasonCodesResult.reasonCodeDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(reasonCodeDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ListReturnReasonCodesResult {\n");
    
    sb.append("    reasonCodeDetails: ").append(toIndentedString(reasonCodeDetails)).append("\n");
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
