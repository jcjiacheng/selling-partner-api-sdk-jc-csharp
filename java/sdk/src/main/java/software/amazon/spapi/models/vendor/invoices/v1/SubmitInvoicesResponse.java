/*
 * Selling Partner API for Retail Procurement Payments
 * The Selling Partner API for Retail Procurement Payments provides programmatic access to vendors payments data.
 *
 * OpenAPI spec version: v1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package software.amazon.spapi.models.vendor.invoices.v1;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import software.amazon.spapi.models.vendor.invoices.v1.ErrorList;
import software.amazon.spapi.models.vendor.invoices.v1.TransactionId;
/**
 * The response schema for the submitInvoices operation.
 */
@Schema(description = "The response schema for the submitInvoices operation.")


public class SubmitInvoicesResponse {
  @SerializedName("payload")
  private TransactionId payload = null;

  @SerializedName("errors")
  private ErrorList errors = null;

  public SubmitInvoicesResponse payload(TransactionId payload) {
    this.payload = payload;
    return this;
  }

   /**
   * Get payload
   * @return payload
  **/
  @Schema(description = "")
  public TransactionId getPayload() {
    return payload;
  }

  public void setPayload(TransactionId payload) {
    this.payload = payload;
  }

  public SubmitInvoicesResponse errors(ErrorList errors) {
    this.errors = errors;
    return this;
  }

   /**
   * Get errors
   * @return errors
  **/
  @Schema(description = "")
  public ErrorList getErrors() {
    return errors;
  }

  public void setErrors(ErrorList errors) {
    this.errors = errors;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SubmitInvoicesResponse submitInvoicesResponse = (SubmitInvoicesResponse) o;
    return Objects.equals(this.payload, submitInvoicesResponse.payload) &&
        Objects.equals(this.errors, submitInvoicesResponse.errors);
  }

  @Override
  public int hashCode() {
    return Objects.hash(payload, errors);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SubmitInvoicesResponse {\n");
    
    sb.append("    payload: ").append(toIndentedString(payload)).append("\n");
    sb.append("    errors: ").append(toIndentedString(errors)).append("\n");
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
