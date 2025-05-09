/*
 * Selling Partner API for A+ Content Management
 * Use the A+ Content API to build applications that help selling partners add rich marketing content to their Amazon product detail pages. Selling partners can use A+ content to share their brand and product story, which helps buyers make informed purchasing decisions. Selling partners use content modules to add images and text.
 *
 * OpenAPI spec version: 2020-11-01
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package software.amazon.spapi.models.apluscontent.v2020_11_01;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import software.amazon.spapi.models.apluscontent.v2020_11_01.AplusPaginatedResponse;
import software.amazon.spapi.models.apluscontent.v2020_11_01.AsinMetadataSet;
/**
 * ListContentDocumentAsinRelationsResponse
 */



public class ListContentDocumentAsinRelationsResponse extends AplusPaginatedResponse {
  @SerializedName("asinMetadataSet")
  private AsinMetadataSet asinMetadataSet = null;

  public ListContentDocumentAsinRelationsResponse asinMetadataSet(AsinMetadataSet asinMetadataSet) {
    this.asinMetadataSet = asinMetadataSet;
    return this;
  }

   /**
   * Get asinMetadataSet
   * @return asinMetadataSet
  **/
  @Schema(required = true, description = "")
  public AsinMetadataSet getAsinMetadataSet() {
    return asinMetadataSet;
  }

  public void setAsinMetadataSet(AsinMetadataSet asinMetadataSet) {
    this.asinMetadataSet = asinMetadataSet;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ListContentDocumentAsinRelationsResponse listContentDocumentAsinRelationsResponse = (ListContentDocumentAsinRelationsResponse) o;
    return Objects.equals(this.asinMetadataSet, listContentDocumentAsinRelationsResponse.asinMetadataSet) &&
        super.equals(o);
  }

  @Override
  public int hashCode() {
    return Objects.hash(asinMetadataSet, super.hashCode());
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ListContentDocumentAsinRelationsResponse {\n");
    sb.append("    ").append(toIndentedString(super.toString())).append("\n");
    sb.append("    asinMetadataSet: ").append(toIndentedString(asinMetadataSet)).append("\n");
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
