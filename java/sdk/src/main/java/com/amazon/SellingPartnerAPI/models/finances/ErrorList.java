/*
 * The Selling Partner API for Finances
 * The Selling Partner API for Finances provides financial information relevant to a seller's business. You can obtain financial events for a given order or date range without having to wait until a statement period closes.
 *
 * OpenAPI spec version: 2024-06-19
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package com.amazon.SellingPartnerAPI.models.finances;

import java.util.Objects;
import java.util.Arrays;
import com.amazon.SellingPartnerAPI.models.finances.Error;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * A list of error responses returned when a request is unsuccessful.
 */
@Schema(description = "A list of error responses returned when a request is unsuccessful.")


public class ErrorList {
  @SerializedName("errors")
  private List<Error> errors = new ArrayList<Error>();

  public ErrorList errors(List<Error> errors) {
    this.errors = errors;
    return this;
  }

  public ErrorList addErrorsItem(Error errorsItem) {
    this.errors.add(errorsItem);
    return this;
  }

   /**
   * The error responses that are returned when the request is unsuccessful.
   * @return errors
  **/
  @Schema(required = true, description = "The error responses that are returned when the request is unsuccessful.")
  public List<Error> getErrors() {
    return errors;
  }

  public void setErrors(List<Error> errors) {
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
    ErrorList errorList = (ErrorList) o;
    return Objects.equals(this.errors, errorList.errors);
  }

  @Override
  public int hashCode() {
    return Objects.hash(errors);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ErrorList {\n");
    
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
