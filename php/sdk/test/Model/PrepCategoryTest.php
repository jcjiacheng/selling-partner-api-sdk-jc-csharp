<?php
/**
 * PrepCategoryTest
 *
 * PHP version 8.3
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

namespace OpenAPI\Client\Test\Model;

use PHPUnit\Framework\TestCase;
use OpenAPI\Client\Model\fulfillment\inbound\v2024_03_20\PrepCategory;

/**
 * PrepCategoryTest Class Doc Comment
 *
 * @category    Class
 * @description The preparation category for shipping an item to Amazon&#39;s fulfillment network.
 * @package     OpenAPI\Client
 */
class PrepCategoryTest extends TestCase
{

    private PrepCategory $model;

    /**
     * Setup before running each test case
     */
    public function setUp(): void
    {
        $this->model = new PrepCategory();
    }

    /**
     * Clean up after running each test case
     */
    public function tearDown(): void
    {
        unset($this->model);
    }

    /**
     * Test "PrepCategory"
     */
    public function testPrepCategory()
    {
        $this->assertInstanceOf(PrepCategory::class, $this->model);
    }
}
